using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using global::ServiceLayer.Interfaces;
using Microsoft.Extensions.Logging;
using RepositoryLayer.Interfaces;
using ServiceLayer.Interfaces;


namespace ServiceLayer.Implementations
{
   

    
        public class AssetService : IAssetService
        {
            private readonly IAssetRepository _assetRepository;
            private readonly ILogger<AssetService> _logger;

            // Dependency Injection
            public AssetService(IAssetRepository assetRepository, ILogger<AssetService> logger)
            {
                _assetRepository = assetRepository;
                _logger = logger;
            }

            // Create Asset
            public Asset CreateAsset(Asset asset)
            {
                _logger.LogInformation("Creating Asset : {AssetCode}", asset.AssetCode);
                return _assetRepository.CreateAsset(asset);
            }

            // Get All Assets
            public IEnumerable<Asset> GetAllAssets()
            {
                return _assetRepository.GetAllAssets();
            }

            // Get Asset By Id
            public Asset? GetAssetById(int assetId)
            {
                return _assetRepository.GetAssetById(assetId);
            }

            // Update Asset
            public Asset UpdateAsset(Asset asset)
            {
                _logger.LogInformation("Updating Asset : {AssetId}", asset.AssetId);
                return _assetRepository.UpdateAsset(asset);
            }

            // Delete Asset
            public bool DeleteAsset(int assetId)
            {
                _logger.LogInformation("Deleting Asset : {AssetId}", assetId);
                return _assetRepository.DeleteAsset(assetId);
            }

            // Search Assets
            public IEnumerable<Asset> SearchAssets(string keyword)
            {
                return _assetRepository.SearchAssets(keyword);
            }
        }
    
}
