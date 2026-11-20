using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using USS.TharaStore.ApiService;
using USS.TharaStore.Business;
using USS.TharaStore.Business.Interface;
using USS.TharaStore.Data;
using USS.TharaStore.Data.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(opts => { opts.JsonSerializerOptions.MaxDepth = 256; opts.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; });
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(opts => { opts.SerializerOptions.MaxDepth = 256; opts.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; });
builder.Services.Configure<Microsoft.AspNetCore.Mvc.JsonOptions>(opts => { opts.JsonSerializerOptions.MaxDepth = 256; opts.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; });
// Add simple console logging to help capture runtime errors when generating OpenAPI
builder.Logging.AddConsole();

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<MainDBContext>(option =>
{

    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});

builder.Services.AddServiceDI();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // show detailed errors in development so we can see stack traces when requesting /openapi/v1.json
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler();
}

// Middleware to log unhandled exceptions during request processing (useful for OpenAPI generation errors)
app.Use(async (context, next) =>
{
    try
    {
        await next();
    }
    catch (Exception ex)
    {
        var logger = app.Services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Unhandled exception while processing request {Path}", context.Request.Path);
        throw;
    }
});

app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUi(o => o.DocumentPath = "openapi/v1.json");
}


app.MapDefaultEndpoints();

app.Run();

