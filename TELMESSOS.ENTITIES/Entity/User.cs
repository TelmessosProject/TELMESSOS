using System;
using System.ComponentModel.DataAnnotations;
using TELMESSOS.CORE.Entities;
using TELMESSOS.CORE.Entities.Interfaces;

namespace TELMESSOS.ENTITIES.Entity
{
    public class User: BaseEntityStatus,ILogEntity
    {
        [StringLength(30), Required]
        public string Username { get; set; }

        [StringLength(30), Required]
        public string Password { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Lastname { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdatededUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
