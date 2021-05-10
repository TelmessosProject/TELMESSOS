using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TELMESSOS.CORE.Types.Abstract;

namespace TELMESSOS.CORE.Types.Concrete
{
    public class ErrorResult:Result,IErrorResult
    {
        public ErrorResult(string message):base(false,message)
        {

        }
    }
}
