using FluentValidation;
using FootballIconsCAPI.Data;
using FootballIconsCAPI.DTOs;
using FootballIconsCAPI.Validators;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(p => p.AddPolicy(MyAllowSpecificOrigins, builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
}));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IValidator<TeamsDTO>, TeamValidator>();
builder.Services.AddScoped<IValidator<NationsDTO>, NationValidator>();
builder.Services.AddDbContext<DataContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
