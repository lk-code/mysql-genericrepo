using Microsoft.EntityFrameworkCore;
using MySqlTest.Data;
using TanvirArjel.EFCore.GenericRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// MySQL
string connectionString = "CONNECTION_STRING";
builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseMySQL(connectionString);
});
builder.Services.AddGenericRepository<DatabaseContext>();
        
// Register Services
builder.Services.AddScoped<IAuthUserRepository, AuthUserRepository>();

builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();