namespace WebApplication2.Models
{
    public class Products : List<Product>
    {
        public Products()
        {
            Add(new Product() { ProductId = 101, ProductName = "Laptop", CategoryName = "Electronics", Manufacturer = "MS-Electronics", Price = 456000 });
            Add(new Product() { ProductId = 102, ProductName = "Iron", CategoryName = "Electrical", Manufacturer = "MS-Electical", Price = 5000 });
            Add(new Product() { ProductId = 103, ProductName = "Biscuts", CategoryName = "Food", Manufacturer = "MS-Food", Price = 60 });
            Add(new Product() { ProductId = 104, ProductName = "Router", CategoryName = "Electronics", Manufacturer = "LS-Electronics", Price = 5600 });
            Add(new Product() { ProductId = 105, ProductName = "Mixer", CategoryName = "Electrical", Manufacturer = "LS-Electrical", Price = 4000 });
            Add(new Product() { ProductId = 106, ProductName = "Chips", CategoryName = "Food", Manufacturer = "LS-Food", Price = 40 });
            Add(new Product() { ProductId = 107, ProductName = "Mouse", CategoryName = "Electronics", Manufacturer = "TS-Electronics", Price = 500 });
            Add(new Product() { ProductId = 108, ProductName = "Dryer", CategoryName = "Electrical", Manufacturer = "TS-Electrical", Price = 4600 });
            Add(new Product() { ProductId = 109, ProductName = "Soya Milk", CategoryName = "Food", Manufacturer = "TS-Food", Price = 45 });
            Add(new Product() { ProductId = 110, ProductName = "Keyboard", CategoryName = "Electronics", Manufacturer = "MS-Electronics", Price = 1600 });
            Add(new Product() { ProductId = 111, ProductName = "Charger", CategoryName = "Electrical", Manufacturer = "LS-Electrical", Price = 600 });
            Add(new Product() { ProductId = 112, ProductName = "Yoghurt", CategoryName = "Food", Manufacturer = "TS-Foods", Price = 40 });
        }
    }
}
