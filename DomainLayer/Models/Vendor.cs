using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace DomainLayer.Models
{
    

    
        public class Vendor
        {
            [Key]
            public int VendorId { get; set; }

            [Required]
            [StringLength(100)]
            public string VendorName { get; set; } = string.Empty;

            [Required]
            [StringLength(100)]
            public string ContactPerson { get; set; } = string.Empty;

            [Required]
            [StringLength(15)]
            public string ContactNumber { get; set; } = string.Empty;

            [StringLength(100)]
            public string? Email { get; set; }

            [StringLength(200)]
            public string? Address { get; set; }

            public bool IsActive { get; set; } = true;

        // Navigation Property
        [JsonIgnore]
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
= new List<PurchaseOrder>();
    }
    
}
