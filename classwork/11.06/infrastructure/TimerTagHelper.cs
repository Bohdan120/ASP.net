using Microsoft.AspNetCore.Razor.TagHelpers;

namespace _11._06.infrastructure
{
    public class TimerTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";     // заміняє тег <timer> тегом <div> 
                                        // встановлюємо вмістиме елемента 
            output.Content.SetContent($"Поточний час: {DateTime.Now.ToString("HH:mm:ss")}");

        }
    }
}
