using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TELMESSOS.CORE.Types.Abstract;

namespace TELMESSOS.CORE.Types.Concrete
{
    public class SuccessDataResult<TData> : DataResult<TData>, ISuccessDataResult<TData>
    {
        public SuccessDataResult(TData data) : base(true, "", data)
        {
        }
        public SuccessDataResult(TData data, string message):base(true,message,data)
        {
        }
    }
}
