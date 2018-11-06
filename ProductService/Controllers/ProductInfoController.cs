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
    public class ProductInfoController : ControllerBase
    {
        private ProductInfoAppService _productInfoAppService;
        public ProductInfoController(ProductInfoAppService productInfoAppService) {
            this._productInfoAppService=  productInfoAppService;
        }
        // GET: api/ProductInfo
        [HttpGet]
        public IEnumerable<ProductInfo> GetProductInfoList()
        {
            return _productInfoAppService.GetProductInfoList();
        }

        // GET: api/ProductInfo/5
        [HttpGet]
        public async Task< ProductInfo> GetProductInfo(string id)
        {
            return await _productInfoAppService.GetProductInfoAsync(id);
        }
        // POST: api/ProductInfo
        [HttpPost]
        public async Task<int> CreateProductInfo(ProductInfo ProductInfo)
        {
            return await _productInfoAppService.CreateProductInfoAsync(ProductInfo);
        }
        // POST: api/UpdateProductInfo
        [HttpPost]
        public async Task<int> UpdateProductInfo(ProductInfo ProductInfo)
        {
            return await _productInfoAppService.UpdateProductInfoAsync(ProductInfo);
        }


        // POST: api/DeleteProductInfo
        [HttpPost]
        public async Task<int> DeleteProductInfo(string id)
        {
            return await _productInfoAppService.DeleteProductInfoAsync(id);
        }


    }
}
