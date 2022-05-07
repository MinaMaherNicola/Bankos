using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.DTOs.Response
{
    public class GenericResponseModel<T> : ResponseModel
    {
        public T? Data { get; set; }

        public GenericResponseModel() : base()
        {

        }
        public GenericResponseModel<T> GenerateSuccess(T? data)
        {
            Data = data;
            return this;
        }

        public GenericResponseModel<T> GenerateSuccess(string message, T? data)
        {
            Message = message;
            Data = data;
            return this;
        }

        public override GenericResponseModel<T> GenerateFailure()
        {
            Message = "Failure";
            Data = default;
            Success = false;
            return this;
        }

        public override GenericResponseModel<T> GenerateFailure(string message)
        {
            Message = message;
            Data = default;
            Success = false;
            return this;
        }
    }
}
