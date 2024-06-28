namespace lesson3_30._05_.infrastruct
{
    public class SimpleTimeService : ITimeService
    {
        public string Time => DateTime.Now.ToString("hh:mm:ss");
    }
}
