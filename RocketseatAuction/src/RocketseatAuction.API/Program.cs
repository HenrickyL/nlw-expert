using Microsoft.AspNetCore.Diagnostics;
using RocketseatAuction.API.Infra.Exceptions;
using System.Net;
using Newtonsoft.Json;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Middleware para tratamento de exceções
app.UseExceptionHandler(errorApp =>
{
    errorApp.Run(async context =>
    {
        context.Response.ContentType = "application/json";

        var ex = context.Features.Get<IExceptionHandlerFeature>()?.Error;
        if (ex != null)
        {
            var statusCode = HttpStatusCode.InternalServerError;
            var errorMessage = "Internal server error";

            switch (ex)
            {
                case NotFoundException _:
                    statusCode = HttpStatusCode.NotFound;
                    errorMessage = ex.Message;
                    break;
                case BadRequestException _:
                    statusCode = HttpStatusCode.BadRequest;
                    errorMessage = ex.Message;
                    break;
                case UnauthorizedException _:
                    statusCode = HttpStatusCode.Unauthorized;
                    errorMessage = ex.Message;
                    break;
                default:
                    break;
            }

            context.Response.StatusCode = (int)statusCode;
            var result = JsonConvert.SerializeObject(new { error = errorMessage });
            await context.Response.WriteAsync(result);
        }
    });
});

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
