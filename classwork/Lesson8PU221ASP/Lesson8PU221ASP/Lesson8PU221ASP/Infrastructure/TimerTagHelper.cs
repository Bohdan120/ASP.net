using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Reflection;

namespace Lesson8PU221ASP.Infrastructure
{
    public interface ITimeService
    {
        string GetTime();
    }
    public class SimpleTimeService : ITimeService
    {
        public string GetTime() => System.DateTime.Now.ToString("HH:mm:ss");
    }
    public class ModernTimeService : ITimeService
    {
        public string GetTime()
        {
            return DateTime.Now.ToString("HH:mm");
        }
    }

    public class TimerTagHelper : TagHelper
    {
        ITimeService timeService;

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext? ViewContext { get; set; }
        public TimerTagHelper(ITimeService timeServ)
        {
            timeService = timeServ;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // Отримуємо зі стрічки запиту параметр font 
            string? font = ViewContext?.HttpContext.Request.Query["font"];

            if (string.IsNullOrEmpty(font)) font = "Verdana";

            output.Attributes.SetAttribute("style", $"font-family:{font};font-size:18px;");
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.SetContent($"Поточний час: {timeService.GetTime()}");
        }
    }


    [HtmlTargetElement("profile")]
    public class ProfileImageTagHelper : TagHelper
    {
        public string? Url { get; set; }
        public int Size { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img";
            output.TagMode = TagMode.SelfClosing; output.Attributes.Add("src", Url);
            output.Attributes.Add("width", Size); output.Attributes.Add("height", Size);
            output.Attributes.Add("style", "border-radius:50%");
        }
    }

 
    [HtmlTargetElement("form-header", ParentTag = "form", Attributes = "form-title")]
    public class HeaderTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h2";
            output.Attributes.RemoveAll("form-title");
        }
    }

    public class ProductTableTagHelper : TagHelper
    {
        public class Product
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public decimal Price { get; set; }

            public Product(int id, string title, decimal price)
            {
                Id = id;
                Title = title;
                Price = price;
            }
        }
        public List<Product> Elements { get; set; } = new();
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "table";
            string listContent = "<tr>";
            foreach (PropertyInfo prop in typeof(Product).GetProperties())
            {
                listContent = $"{listContent}<th>{prop.Name}</th>";
            }

            listContent = $"{listContent}</tr>";

            foreach (Product item in Elements)
                listContent = $"{listContent}<tr><td>{item.Id}</td><td>{item.Title}</td><td>{item.Price}</td></tr>";

            output.Content.SetHtmlContent(listContent);
        }


    }
}
