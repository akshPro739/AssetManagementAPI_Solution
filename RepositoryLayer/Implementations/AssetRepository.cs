using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using global::RepositoryLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Interfaces;

namespace RepositoryLayer.Implementations
{
  

    
        public class AssetRepository : IAssetRepository
        {
            private readonly AssetManagementDbContext _context;

            // Dependency Injection
            public AssetRepository(AssetManagementDbContext context)
            {
                _context = context;
            }

            // Create Asset
            public Asset CreateAsset(Asset asset)
            {
                _context.Assets.Add(asset);
                _context.SaveChanges();
                return asset;
            }

            // Get All Assets
            public IEnumerable<Asset> GetAllAssets()
            {
                return _context.Assets
                    .Include(a => a.PurchaseOrder)
                    .ToList();
            }

            // Get Asset By Id
            public Asset? GetAssetById(int assetId)
            {
                return _context.Assets
                    .Include(a => a.PurchaseOrder)
                    .FirstOrDefault(a => a.AssetId == assetId);
            }

            // Update Asset
            public Asset UpdateAsset(Asset asset)
            {
                _context.Assets.Update(asset);
                _context.SaveChanges();
                return asset;
            }

            // Delete Asset
            public bool DeleteAsset(int assetId)
            {
                var asset = _context.Assets.Find(assetId);

                if (asset == null)
                {
                    return false;
                }

                _context.Assets.Remove(asset);
                _context.SaveChanges();

                return true;
            }

            // Search Assets
            public IEnumerable<Asset> SearchAssets(string keyword)
            {
                return _context.Assets
                    .Include(a => a.PurchaseOrder)
                    .Where(a =>
                        a.AssetCode.Contains(keyword) ||
                        a.SerialNumber.Contains(keyword))
                    .ToList();
            }
        }
    
}
