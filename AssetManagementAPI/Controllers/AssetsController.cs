using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interfaces;

namespace AssetManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        private readonly IAssetService _assetService;

        // Dependency Injection
        public AssetsController(IAssetService assetService)
        {
            _assetService = assetService;
        }

        // Create Asset
        [HttpPost]
        public IActionResult CreateAsset(Asset asset)
        {
            try
            {
                var result = _assetService.CreateAsset(asset);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Get All Assets
        [HttpGet]
        public IActionResult GetAllAssets()
        {
            try
            {
                return Ok(_assetService.GetAllAssets());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Get Asset By Id
        [HttpGet("{id}")]
        public IActionResult GetAssetById(int id)
        {
            try
            {
                var asset = _assetService.GetAssetById(id);

                if (asset == null)
                {
                    return NotFound("Asset not found");
                }

                return Ok(asset);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Update Asset
        [HttpPut]
        public IActionResult UpdateAsset(Asset asset)
        {
            try
            {
                return Ok(_assetService.UpdateAsset(asset));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Delete Asset
        [HttpDelete("{id}")]
        public IActionResult DeleteAsset(int id)
        {
            try
            {
                bool status = _assetService.DeleteAsset(id);

                if (!status)
                {
                    return NotFound("Asset not found");
                }

                return Ok("Asset Deleted Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Search Asset
        [HttpGet("Search/{keyword}")]
        public IActionResult SearchAsset(string keyword)
        {
            try
            {
                return Ok(_assetService.SearchAssets(keyword));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}