using LR1;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

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

// 1
var company = new Company("TWU Industrial", "31 Nord Street, Kyiv", "travel agency", 250);
app.MapGet("/", () => company.ToString());

// 2
/*Random randomValue = new Random();
app.MapGet("/", () => randomValue.Next(0, 101));*/


// додавання компонента middleware
/*app.Run(async (context) =>
{
    var company = new Company("TWU Industrial", "31 Nord Street, Kyiv", "travel agency", 250);
    await context.Response.WriteAsync($"{company}\n\n");
    //Console.WriteLine(company);

    Random randomValue = new Random();
    await context.Response.WriteAsync($"Random value = {randomValue.Next(0, 101)}");
});*/

app.Run();