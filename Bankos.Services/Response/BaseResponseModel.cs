using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.Response
{
    public class BaseResponseModel
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; } = "Success";

        public virtual void GenerateSuccess(string message)
        {
            Message = message;
        }

        public void GenerateFailure(string message)
        {
            Message = message;
            Success = false;
        }
    }
}
