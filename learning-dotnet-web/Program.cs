using learning_dotnet_web.Repositories;
using learning_dotnet_web.Data;
using learning_dotnet_web.Services;

var builder = WebApplication.CreateBuilder(args);

// Database context
builder.Services.AddDbContext<LearningContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

// Repository registry
builder.Services.AddScoped<UserRepository>();

// Service registry
builder.Services.AddScoped<UserService>();

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
    pattern: "{controller=User}/{action=All}/{id?}"
);

app.Run();