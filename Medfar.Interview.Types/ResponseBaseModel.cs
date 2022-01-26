using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medfar.Interview.Types
{
    public class ResponseBaseModel
    {
        public ResponseBaseModel()
        {
            IsSuccess = true;
            ErrorMessage = string.Empty;
            DetailedError = string.Empty;
        }
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public string DetailedError { get; set; }
    }
}
