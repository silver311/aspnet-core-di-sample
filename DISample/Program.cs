using DISample.Abstractions;
using DISample.Dependencies;
using DISample.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<ISampleLog, SampleLog>();
builder.Services.AddScoped<ISampleService, SampleService>();
//builder.Services.AddTransient<ISampleLog, SampleLog>();
//builder.Services.AddSingleton<ISampleLog, SampleLog>();
// Different implementation
// builder.Services.AddScoped<ISampleLog, SampleLog2>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapControllers();

app.Run();
