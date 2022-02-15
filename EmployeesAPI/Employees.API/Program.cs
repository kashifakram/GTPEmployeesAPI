using Employee.Repository;
using Employee.Repository.Interfaces;
using Employees.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

const string allowSpecificOrigins = "localhost:3000";

builder.Services.AddCors(o => o.AddPolicy(name: allowSpecificOrigins, builder =>
{
    builder.WithOrigins("http://localhost:3000/");
}));

var connectionString = builder.Configuration.GetConnectionString("LocalCS");


builder.Services.AddControllers();


builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();
builder.Services.AddScoped<IRepoWrapper, RepoWrapper>();

builder.Services.AddEndpointsApiExplorer();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
}

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true)
    .AllowCredentials());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
