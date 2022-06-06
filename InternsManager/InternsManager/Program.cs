using InternsManager.BL.Classes;
using InternsManager.BL.Interfaces;
using InternsManager.DAL.Migrations;
using InternsManager.DAL.Repositories;
using InternsManager.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=InternsDB;Trusted_Connection=True;MultipleActiveResultSets=true";

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDbContext<ApplicationDbContext>(ServiceLifetime.Transient);

#region Transient
builder.Services.AddScoped(typeof(IRepository<>), typeof(InternsManagerRepository<>));
builder.Services.AddTransient<IInternLogic, InternLogic>();
builder.Services.AddTransient<IPersonLogic, PersonLogic>();
builder.Services.AddTransient<IInternshipLogic, InternshipLogic>();
#endregion


builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseRouting();

app.MapControllers();

app.UseEndpoints(endpoints => endpoints.MapControllers());

app.Run();
