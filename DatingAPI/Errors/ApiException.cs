using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAPI.Errors
{
    public class ApiException
    {
        public ApiException(int _statusCode,string _msg=null,string _details=null)
        {
            StatusCode = _statusCode;
            Message = _msg;
            Details = _details;
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
    }
}
