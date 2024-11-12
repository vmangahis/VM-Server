using VM_Server.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureSqlServer();
builder.Services.ConfigureCors();

builder.Services.ConfigureRepositoryManager();

var app = builder.Build();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// Configure the HTTP request pipeline.
if (app.Environment.IsProduction())
{
    app.UseHsts();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://127.0.0.1:4200/VM-Dev/", "https://vmangahis.github.io/VM-Dev/", "https://localhost:4200/VM-Dev/"));

app.Run();
