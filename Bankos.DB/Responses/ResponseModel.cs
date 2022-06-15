using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.DB.Responses
{
    public class ResponseModel
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; } = null!;

        public void GenerateSuccess(string message)
        {
            Message = message;
        }

        public void GenerateFailure(string message)
        {
            Success = false;
            Message = message;
        }
    }
}
