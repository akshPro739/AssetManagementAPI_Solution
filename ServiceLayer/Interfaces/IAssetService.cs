using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;

namespace ServiceLayer.Interfaces
{
    

    
        public interface IAssetService
        {
            // Create Asset
            Asset CreateAsset(Asset asset);

            // Get All Assets
            IEnumerable<Asset> GetAllAssets();

            // Get Asset By Id
            Asset? GetAssetById(int assetId);

            // Update Asset
            Asset UpdateAsset(Asset asset);

            // Delete Asset
            bool DeleteAsset(int assetId);

            // Search Assets
            IEnumerable<Asset> SearchAssets(string keyword);
        }
    
}
