var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.Use(async (context, next) =>
{
    context.Items["data"] = "SomeData";
    await next.Invoke();

});

//app.Use(async (context, next) =>
//{
//    if (context.Items.ContainsKey("data"))
//    {
//        await context.Response.WriteAsync($"data= {context.Items["data"]}");
//    }
//    else
//    {
//        await next.Invoke();
//    }

//});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
