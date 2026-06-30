using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace DomainLayer.Models
{
    

    
        public class User
        {
            [Key]
            public int UserId { get; set; }

            [Required]
            [StringLength(50)]
            public string UserName { get; set; } = string.Empty;

            [Required]
            [StringLength(100)]
            public string Password { get; set; } = string.Empty;

            [Required]
            public int RoleId { get; set; }

            public bool IsActive { get; set; } = true;

            public DateTime CreatedDate { get; set; } = DateTime.Now;


        [ForeignKey("RoleId")]
        [JsonIgnore]
        public virtual Role? Role { get; set; }
    }
    
}
