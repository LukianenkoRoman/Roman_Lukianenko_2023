using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(    //Here i create default path for index page 
        name: "default",
        pattern: "{controller=Home}/{action=PreLoger}/{id?}");

    endpoints.MapControllerRoute(    //And here i creating path to index with PreLoger
        name: "PreLoger",
        pattern: "Home/PreLoger", 
        defaults: new { controller = "Home", action = "PreLoger" });
});

app.MapRazorPages();

app.Run();


