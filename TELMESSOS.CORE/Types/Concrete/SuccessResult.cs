using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TELMESSOS.CORE.Types.Abstract;

namespace TELMESSOS.CORE.Types.Concrete
{
    public class SuccessResult : Result, ISuccessResult
    {
        public SuccessResult():base(true, null)
        {

        }
        public SuccessResult(string message):base(true,message)
        {

        }

    }
}
