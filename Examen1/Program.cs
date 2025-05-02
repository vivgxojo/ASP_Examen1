var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();


app.MapControllerRoute(
    name: "default",
    pattern: "/",
    defaults: new { controller = "Hotel", action = "Index" }
);

app.MapControllerRoute(
    name: "default",
    pattern: "/{MotCle}",
    defaults: new { controller = "Hotel", action = "Rechercher" }
);

app.MapControllerRoute(
    name: "default",
    pattern: "/{Username}/{NoEnregistrement}",
    defaults: new { controller = "Hotel", action = "Reserver" }
);
app.Run();
