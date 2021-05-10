using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TELMESSOS.CORE.Types.Abstract;

namespace TELMESSOS.CORE.Types.Concrete
{
    public class ErrorDataResult<TData> : DataResult<TData>, ISuccessDataResult<TData>
    {
        public ErrorDataResult() : base(false, "", default)
        {

        }

        public ErrorDataResult(TData data) : base(false, "", data)
        {
            
        }
        public ErrorDataResult(string message) : base(false, message, default)
        {

        }
        public ErrorDataResult(TData data, string message):base(false,message,data)
        {
            
        }
    }
}
