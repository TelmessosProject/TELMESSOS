using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TELMESSOS.CORE.Entities;

namespace TELMESSOS.ENTITIES.Entity
{
    public class BaseEntityCodeStatus : BaseEntityStatus
    {
        [StringLength(50)]
        public string Code { get; set; }
    }
}
