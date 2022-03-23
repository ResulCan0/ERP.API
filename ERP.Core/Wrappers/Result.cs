using Newtonsoft.Json;

namespace ERP.Business.Helper;

public class Result
{
    public int StatusCode { get; set; }
    
    public string Message { get; set; }

    public string? ErrorDetail { get; set; }

    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}