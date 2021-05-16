using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TELMESSOS.CORE.Types.Abstract;

namespace TELMESSOS.CORE.Types.Concrete
{
    public class Result:IResult
    {
        public Result(bool success, string message)
        {
            Success = success;
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; set; }
        public string Message { get; set; }

        
    }
}
