using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.DB.Responses
{
    public class ResponseModel
    {
        private bool _success = true;
        private string _message = null!;

        public void GenerateSuccess(string message)
        {
            _message = message;
        }

        public void GenerateFailure(string message)
        {
            _success = false;
            _message = message;
        }
    }
}
