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
    public class ProductInfoAppService  
    {
        private readonly ProductDBContext _context;
        public ProductInfoAppService(ProductDBContext context)
        {
            _context = context;
        }
        #region ProductInfo 操作
        public IEnumerable<ProductInfo> GetProductInfoList()
        {
            return _context.ProductInfos;
        }
        public IEnumerable<ProductInfo> GetProductInfoListWithCateIdAsync(string cateId)
        {
            return _context.ProductInfos.Where(x => x.Cateid == cateId);
        }
        public async Task<ProductInfo> GetProductInfoAsync(string id)
        {
            return await _context.ProductInfos.FirstOrDefaultAsync(x => x.Pid == id);
        }
        public async Task<int> UpdateProductInfoAsync(ProductInfo product)
        {
            if (ProductInfoExists(product.Pid))
            {
                _context.Entry(product).State = EntityState.Modified;
            }
            else
            {
            }
            return await _context.SaveChangesAsync();
        }
        public async Task<int> CreateProductInfoAsync(ProductInfo product)
        {
            _context.ProductInfos.Add(product);
            return await _context.SaveChangesAsync();
        }


        public async Task<int> DeleteProductInfoAsync(string id)
        {

            if (ProductInfoExists(id))
            {
                var product = await _context.ProductInfos.FirstOrDefaultAsync(x => x.Pid == id);
                _context.ProductInfos.Remove(product);
            }
            return await _context.SaveChangesAsync();
        }

        private bool ProductInfoExists(string id)
        {
            return _context.ProductInfos.Any(e => e.Pid == id);
        }
        #endregion

         
    }
}