using Microsoft.AspNetCore.Mvc;

namespace ViewComponentSample.Infrastructure
{
    //public class TimerViewComponent
    //{
    //    public string Invoke()
    //    {
    //        return $"Поточний час: {DateTime.Now.ToString("hh:mm:ss")}";
    //    }
    //}


    //[ViewComponent]
    //public class Timer
    //{
    //    public string Invoke(bool includeSeconds)
    //    {
    //        if (includeSeconds)
    //            return $"Поточний час: {DateTime.Now.ToString("hh:mm:ss")}";
    //        else
    //            return $"Поточний час: {DateTime.Now.ToString("hh:mm")}";
    //    }
    //}

    //public record class Product(int Id, string Title, int Price); public class ProductInfoViewComponent
    //{
    //    public string Invoke(Product Product)
    //    {
    //        return $"Title: {Product.Title}  Price: {Product.Price}";
    //    }
    //}

    public interface ITimeService
    {
        string GetTime();
    }
    public class SimpleTimeService : ITimeService
    {
        public string GetTime() => DateTime.Now.ToString("HH:mm:ss");
    }
    [ViewComponent]
    public class Timer
    {
        ITimeService timeService;
        public Timer(ITimeService service)
        {
            timeService = service;
        }
        public string Invoke()
        {
            return $"Поточний час: {timeService.GetTime()}";
        }
    }

    public class UsersListViewComponent : ViewComponent
    {
        List<string> users = new List<string>
        {
            "John", "Tony", "Den", "Ron"
        };
        public IViewComponentResult Invoke()
        {
            return View(users);
        }
    }

}
