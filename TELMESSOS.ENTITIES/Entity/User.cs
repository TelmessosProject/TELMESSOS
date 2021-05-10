using System.ComponentModel.DataAnnotations;
using TELMESSOS.CORE.Entities;

namespace TELMESSOS.ENTITIES.Entity
{
    public class User:CoreEntity
    {
        [StringLength(30), Required]
        public string Username { get; set; }

        [StringLength(30), Required]
        public string Password { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Lastname { get; set; }
    }
}
