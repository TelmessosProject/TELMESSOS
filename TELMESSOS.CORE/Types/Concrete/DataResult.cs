using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TELMESSOS.CORE.Types.Abstract;

namespace TELMESSOS.CORE.Types.Concrete
{
    public class DataResult<TData> : Result, IDataResult<TData>
    {
        public DataResult(bool success, string message, TData data):base(success,message)
        {
            Data = data;
        }
        public TData Data { get; set; }
    }
}
