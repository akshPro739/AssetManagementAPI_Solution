using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.ViewModel
{
    
        public class UserRegisterVM
        {
            [Required]
            [StringLength(50)]
            public string UserName { get; set; } = string.Empty;

            [Required]
            [StringLength(100)]
            public string Password { get; set; } = string.Empty;

            [Required]
            public int RoleId { get; set; }

            public bool IsActive { get; set; } = true;
        }
    
}
