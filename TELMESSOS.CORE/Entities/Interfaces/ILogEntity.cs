using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TELMESSOS.CORE.Entities.Interfaces
{
    public interface ILogEntity
    {
        //? bunu neden class olarak tanımlamadık? 
        int CreatedUserId { get; set; }
        int UpdatededUserId { get; set; }
        DateTime CreatedTime { get; set; }
        DateTime UpdatedTime { get; set; }
    }
}
