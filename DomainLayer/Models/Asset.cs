using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    

    
        public class Asset
        {
            [Key]
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
            public DateTime AssetCreatedDate { get; set; } = DateTime.Now;

            [Required]
            [StringLength(50)]
            public string AssetStatus { get; set; } = "Available";

            [StringLength(100)]
            public string? Location { get; set; }

            [StringLength(100)]
            public string? AssignedTo { get; set; }

            public bool IsActive { get; set; } = true;

        // Navigation Property
        [ForeignKey("PurchaseOrderId")]
        [JsonIgnore]
        public virtual PurchaseOrder? PurchaseOrder { get; set; }
    }
    
}
