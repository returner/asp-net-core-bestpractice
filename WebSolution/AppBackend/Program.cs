using AppBackend.Configuration;
using AppBackend.Filters;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var appSettings = new ConfigurationService(EnvironmentType.AspNetCore, AppContext.BaseDirectory).Build();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// swagger 설정
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = appSettings.Swagger?.Title ?? string.Empty,
        Version = appSettings.Swagger?.Version ?? string.Empty,
        Description = appSettings.Swagger?.Description ?? string.Empty,
        Contact = new OpenApiContact
        {
            Email = string.Empty,
            Url = new Uri(appSettings.Swagger?.Link ?? string.Empty),
        }
    });
    c.EnableAnnotations();
    c.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
    });
    c.OperationFilter<AuthorizeAndParametersOperationFilter>();
    // swagger에 표시해줄 정보를 생성하기 위해 빌드시 xml파일 생성
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath, includeControllerXmlComments: true);
});


// dependency injection
builder.Services.AddSingleton(appSettings);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
