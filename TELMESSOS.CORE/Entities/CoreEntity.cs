using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TELMESSOS.CORE.Entities
{
    public class CoreEntity
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        //? burayı neden virtual yaptık?
        public virtual int Id { get; set; }
    }
}
