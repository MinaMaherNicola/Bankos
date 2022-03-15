using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.Response
{
    public class GenericResponseModel<T> : BaseResponseModel
    {
        public T? Data { get; set; } = default;
        

        public void GenerateSuccess(T? data)
        {
            Data = data;
        }

        public void GenerateSuccess(T? data, string message)
        {
            Data = data;
            Message = message;
        }
    }
}
