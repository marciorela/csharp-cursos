var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseRouting();

app.MapControllerRoute(
    name: "default1",
    pattern: "{controller=home}/{action=index}/{id?}"
);

app.MapControllerRoute(
    name: "default2",
    pattern: "{controller}/{action}/{id?}",
    defaults: new { controller = "home", action = "index"}
);



app.Run();

//app.MapGet("/", () => "Olá, boa noite");


