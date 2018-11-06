using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.Domain.AppServices;
using ProductService.Domain.Models;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImageInfoController : ControllerBase
    {
        private ProductImageInfoAppService _productImageInfoAppService;
        public ProductImageInfoController(ProductImageInfoAppService productImageInfoAppService) {
            this._productImageInfoAppService=  productImageInfoAppService;
        }
        // GET: api/ProductImageInfo
        [HttpGet]
        public IEnumerable<ProductImageInfo> GetProductImageInfoList()
        {
            return _productImageInfoAppService.GetProductImageInfoList();
        }

        // GET: api/ProductImageInfo/5
        [HttpGet]
        public async Task< ProductImageInfo> GetProductImageInfo(string id)
        {
            return await _productImageInfoAppService.GetProductImageInfoAsync(id);
        }
        // POST: api/ProductImageInfo
        [HttpPost]
        public async Task<int> CreateProductImageInfo(ProductImageInfo ProductImageInfo)
        {
            return await _productImageInfoAppService.CreateProductImageInfoAsync(ProductImageInfo);
        }
        // POST: api/UpdateProductImageInfo
        [HttpPost]
        public async Task<int> UpdateProductImageInfo(ProductImageInfo ProductImageInfo)
        {
            return await _productImageInfoAppService.UpdateProductImageInfoAsync(ProductImageInfo);
        }


        // POST: api/DeleteProductImageInfo
        [HttpPost]
        public async Task<int> DeleteProductImageInfo(string id)
        {
            return await _productImageInfoAppService.DeleteProductImageInfoAsync(id);
        }


    }
}
