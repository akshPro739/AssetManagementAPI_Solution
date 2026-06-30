using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
   

    
        public class Role
        {
            [Key]
            public int RoleId { get; set; }

            [Required]
            [StringLength(30)]
            public string RoleName { get; set; } = string.Empty;

        // Navigation Property
        [JsonIgnore]
        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
    
}
