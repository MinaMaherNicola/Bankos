using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.DTOs.Response
{
    public class ResponseModel
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; } = "Success!";

        public ResponseModel()
        {

        }

        public ResponseModel GenerateSuccess()
        {
            return this;
        }

        public ResponseModel GenerateSuccess(string message)
        {
            Message = message;
            return this;
        }

        public virtual ResponseModel GenerateFailure()
        {
            Success = false;
            Message = "Failure!";
            return this;
        }

        public virtual ResponseModel GenerateFailure(string message)
        {
            Success = false;
            Message = message;
            return this;
        }
    }
}
