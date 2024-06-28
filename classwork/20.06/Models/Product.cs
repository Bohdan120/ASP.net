namespace _20._06.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return $"id:{Id} Name:{Name} Price:{Price}";
        }
    }
}
