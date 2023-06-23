using Example_DI.Providers;
using Example_DI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection#service-lifetimes
if (builder.Configuration.GetSection("UseFakeProvider").Value == true.ToString())
{
    builder.Services.AddScoped<IProvider, FakeProvider>();
    builder.Services.AddTransient<IUserRepository, FakeUserRepository>();
}
else
{
    builder.Services.AddScoped<IProvider, ClientProvider>();
    builder.Services.AddTransient<IUserRepository, UserRepository>();
}

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

app.UseAuthorization();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}");

app.Run();