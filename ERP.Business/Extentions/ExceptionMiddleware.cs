using System.Net;
using Microsoft.AspNetCore.Http;

namespace ERP.Business;

public class ExceptionMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int) HttpStatusCode.BadRequest;

            await context.Response.WriteAsJsonAsync(ex.Data);
        }
    }
}
