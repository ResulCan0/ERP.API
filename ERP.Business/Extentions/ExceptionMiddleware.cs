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
                case UserFriendlyException:
                    result.StatusCode = (int) ((UserFriendlyException) ex).SubStatusCode;
                    result.Message = ((UserFriendlyException) ex).ExceptionTypeEnum.ToString();
                    result.ErrorDetail=((UserFriendlyException) ex).ErrorMessage;
                    break;
            }

            await context.Response.WriteAsJsonAsync(result);
        }
    }
}