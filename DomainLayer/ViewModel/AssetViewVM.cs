using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.ViewModel
{
    
        public class AssetViewVM
        {
            public int AssetId { get; set; }

            public string AssetCode { get; set; } = string.Empty;

            public string SerialNumber { get; set; } = string.Empty;

            public string AssetType { get; set; } = string.Empty;

            public string AssetName { get; set; } = string.Empty;

            public string VendorName { get; set; } = string.Empty;

            public string Status { get; set; } = string.Empty;

            public string? Location { get; set; }

            public string? AssignedTo { get; set; }
        }
    
}
