using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.DB.Responses
{
    public class GenericResponseModel<T> : ResponseModel
    {
        public T? Data { get; set; }

        public void GenerateSuccess(T? data, string message = "Success")
        {
            GenerateSuccess(message);
            Data = data;
        }

        public void GenerateFailure(T? data, string message = "Failure")
        {
            GenerateFailure(message);
            Data = data;
        }
    }
}
