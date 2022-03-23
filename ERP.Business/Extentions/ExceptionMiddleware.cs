using System.Net;
using ERP.Business.Helper;
using Microsoft.AspNetCore.Http;

namespace ERP.Business.Extentions;

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

            Result result = new Result();
            switch (ex)
            {
                case UserFriendlyException e:
                    result.StatusCode = e.SubStatusCode;
                    result.Message = e.ExceptionTypeEnum.ToString();
                    result.ErrorDetail = e.ErrorMessage;
                    break;
            }

            await context.Response.WriteAsJsonAsync(result);
        }
    }
}