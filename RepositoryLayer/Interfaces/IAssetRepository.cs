using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;

namespace RepositoryLayer.Interfaces
{


    
        public interface IAssetRepository
        {
            Asset CreateAsset(Asset asset);

            IEnumerable<Asset> GetAllAssets();

            Asset? GetAssetById(int assetId);

            Asset UpdateAsset(Asset asset);

            bool DeleteAsset(int assetId);

            IEnumerable<Asset> SearchAssets(string keyword);
        }
    
}
