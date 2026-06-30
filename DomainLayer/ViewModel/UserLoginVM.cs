using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.ViewModel
{
    
        public class UserLoginVM
        {
            [Required]
            public string UserName { get; set; } = string.Empty;

            [Required]
            public string Password { get; set; } = string.Empty;
        }
    
}
