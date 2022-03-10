using System.Net;

namespace ERP.Business.Helper;

public class UseFriendlyException: CustomException
{
    public Enum ExceptionTypeEnum { get; set; }
    public UseFriendlyException(Enum exceptionTypeEnum, List<string>? errors = default, HttpStatusCode httpStatusCode = HttpStatusCode.NoContent)
        : base("Failures Occured.", errors, httpStatusCode)
    {
        ExceptionTypeEnum = exceptionTypeEnum;
    }
}