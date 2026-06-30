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
    

   
        public class PurchaseOrder
        {
            [Key]
            public int PurchaseOrderId { get; set; }

            [Required]
            public int VendorId { get; set; }

            [Required]
            public int AssetDefinitionId { get; set; }

            [Required]
            public int Quantity { get; set; }

            [Required]
            [Column(TypeName = "decimal(18,2)")]
             public decimal UnitPrice { get; set; }

        [Required]
            public DateTime PurchaseDate { get; set; } = DateTime.Now;

            [Required]
            [StringLength(50)]
            public string Status { get; set; } = "Asset Details Registered Internally";

        // Navigation Properties

        [ForeignKey("VendorId")]
        [JsonIgnore]
        public virtual Vendor? Vendor { get; set; }

        [ForeignKey("AssetDefinitionId")]
        [JsonIgnore]
        public virtual AssetDefinition? AssetDefinition { get; set; }

        [JsonIgnore]
        public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();
    }
    
}
