using System.Net;

namespace ERP.Business.Helper;

public class UserFriendlyException : CustomException
{
    public Enum ExceptionTypeEnum { get; set; }
    
    public string ErrorMessage { get; set; }

    public int SubStatusCode { get; set; }
    public UserFriendlyException(Enum exceptionTypeEnum, List<string>? errors = default, HttpStatusCode httpStatusCode = HttpStatusCode.NoContent)
        : base("Failures Occured.", errors, httpStatusCode)
    {
        ExceptionTypeEnum = exceptionTypeEnum;

        ErrorMessage = errors![0];

        SubStatusCode = exceptionTypeEnum.GetHashCode();
    }
}