namespace lesson4_03._06_.Infrastructure
{
    public class SimpleTimeService : ITimeService
    {
        public string Time => DateTime.Now.ToString();
    }
}
