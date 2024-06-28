using _21._06.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace _21._06.Helpers
{
    public class ProductCardTagHelper : TagHelper
    {
        private static readonly List<ProductModel> products = new List<ProductModel>
        {
            new ProductModel
            {
                Name = "iPhone 13 Pro",
                Description = "Brand: Apple Smartphone Screen: 6.1\"; OLED; 1170x2532; 120 Hz RAM: 6 GB Processor: Apple A15 Bionic OS: iOS 15 Battery: 3095 mAh (non-removable) Camera: 12 (f / 1.5, wide-angle) + 12 (f / 1.8, 120 degrees) , ultra-wide-angle) + 12 (f / 2.8, 3x telephoto lens) MpBody: glass/steel; 204 g; thickness 7.65 mmNFC: + (Apple Pay)",
                Price = 649.99,
                ImageUrl = "https://hotline.ua/img/tx/320/3207787115.jpg"
            },
            new ProductModel
            {
                Name = "samsung s22 ultra",
                Description = "Brand: Samsung Smartphone Screen: 6.8\"; AMOLED; 3080x1440; 120 Hz Processor: Samsung Exynos 2200 OS: Android 12 Battery: 5000 mAh (non-removable) Camera: 108 (f/1.8, wide-angle) + 12 (f/2.2, ultra-wide-angle, 120 degrees) + 10 (f/2.4, 3x telephoto lens) + 10 (f/4.9, 10x telephoto lens) MpBody: glass/aluminum; 229 g; thickness 8.9 mmNFC: +",
                Price = 739.99,
                ImageUrl = "https://hotline.ua/img/tx/424/4244103185.jpg"
            },
            new ProductModel
            {
                Name = "Google Pixel 8 Pro",
                Description = "Smartphone Screen: 6.7\"; OLED; 2992x1344; 120 Hz Memory: 128 GB RAM: 12 GB Processor: Google Tensor G3 OS: Android 14 Battery: 5050 mAh (non-removable) Camera: 50 (f/1.68, wide-angle) + ... Housing: glass/aluminum; 213 g; thickness 8.8 mmNFC: +",
                Price = 659.99,
                ImageUrl = "https://hotline.ua/img/tx/414/4143417275.jpg"
            }
        };

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "product-cards-container");

            foreach (var product in products)
            {
                var content = $@"
                    <div class='product-card'>
                        <div class='product-image'>
                            <img src='{product.ImageUrl}' alt='{product.Name}' />
                        </div>
                        <div class='product-details'>
                            <h2>{product.Name}</h2>
                            <a href='/Home/Details?name={product.Name}'>View Details</a>
                            <span class='product-price'>{$"{product.Price}$"}</span>
                        </div>
                    </div>";

                output.Content.AppendHtml(content);
            }
        }
    }
}
