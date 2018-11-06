using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductService;
using ProductService.Controllers;
using ProductService.Domain.Models;

namespace ProductService.Domain.AppServices
{
  
    public class ProductImageInfoAppService
    {
        private readonly ProductDBContext _context;

        public ProductImageInfoAppService(ProductDBContext context)
        {
            _context = context;
        }
         

        #region ProductImageInfo 操作
        public IEnumerable<ProductImageInfo> GetProductImageInfoList()
        {
            return _context.ProductImageInfos;
        }
       
        public async Task<ProductImageInfo> GetProductImageInfoAsync(string id)
        {
            return await _context.ProductImageInfos.FirstOrDefaultAsync(x => x.PImgId == id);
        }
        public async Task<int> UpdateProductImageInfoAsync(ProductImageInfo ProductImageInfo)
        {
            if (ProductImageInfoExists(ProductImageInfo.PImgId))
            {
                _context.Entry(ProductImageInfo).State = EntityState.Modified;
            }
            else
            {
            }
            return await _context.SaveChangesAsync();
        }
        public async Task<int> CreateProductImageInfoAsync(ProductImageInfo ProductImageInfo)
        {
            _context.ProductImageInfos.Add(ProductImageInfo);
            return await _context.SaveChangesAsync();
        }


        public async Task<int> DeleteProductImageInfoAsync(string id)
        {

            if (ProductImageInfoExists(id))
            {
                var ProductImageInfo = await _context.ProductImageInfos.FirstOrDefaultAsync(x => x.PImgId == id);
                _context.ProductImageInfos.Remove(ProductImageInfo);
            }
            return await _context.SaveChangesAsync();
        }

        private bool ProductImageInfoExists(string id)
        {
            return _context.ProductImageInfos.Any(e => e.PImgId == id);
        }
        #endregion
    }
}