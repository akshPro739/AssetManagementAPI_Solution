using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.ViewModel
{
  
        public class AssetUpdateVM
        {
            [Required]
            public int AssetId { get; set; }

            [Required]
            public int PurchaseOrderId { get; set; }

            [Required]
            [StringLength(50)]
            public string AssetCode { get; set; } = string.Empty;

            [Required]
            [StringLength(100)]
            public string SerialNumber { get; set; } = string.Empty;

            [Required]
            public DateTime AssetCreatedDate { get; set; }

            [Required]
            public string AssetStatus { get; set; } = string.Empty;

            public string? Location { get; set; }

            public string? AssignedTo { get; set; }

            public bool IsActive { get; set; }
        }
    
}
