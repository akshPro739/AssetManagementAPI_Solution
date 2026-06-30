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
    

    
        public class AssetDefinition
        {
            [Key]
            public int AssetDefinitionId { get; set; }

            [Required]
            [StringLength(100)]
            public string AssetName { get; set; } = string.Empty;

            [Required]
            [StringLength(100)]
            public string Brand { get; set; } = string.Empty;

            [Required]
            [StringLength(100)]
            public string Model { get; set; } = string.Empty;

            [Required]
            public int AssetTypeId { get; set; }

            public string? Description { get; set; }

            public bool IsActive { get; set; } = true;

        // Navigation Property
        [ForeignKey("AssetTypeId")]
        [JsonIgnore]
        public virtual AssetType? AssetType { get; set; }

        [JsonIgnore]
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
            = new List<PurchaseOrder>();
    }
    
}
