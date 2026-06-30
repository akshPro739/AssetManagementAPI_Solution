using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;



namespace DomainLayer.Models
{
    

  
        public class AssetType
        {
            [Key]
            public int AssetTypeId { get; set; }

            [Required]
            [StringLength(50)]
            public string AssetTypeName { get; set; } = string.Empty;

            [StringLength(200)]
            public string? Description { get; set; }

            public bool IsActive { get; set; } = true;

        // Navigation Property
        [JsonIgnore]
        public virtual ICollection<AssetDefinition> AssetDefinitions { get; set; }
= new List<AssetDefinition>();
    }
    
}
