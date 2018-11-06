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
  
    public class CategoryInfoAppService  
    {
        private readonly ProductDBContext _context;

        public CategoryInfoAppService(ProductDBContext context)
        {
            _context = context;
        }
         

        #region CategoryInfo 操作
        public IEnumerable<CategoryInfo> GetCategoryInfoList()
        {
            return _context.CategoryInfos;
        }
       
        public async Task<CategoryInfo> GetCategoryInfoAsync(string id)
        {
            return await _context.CategoryInfos.FirstOrDefaultAsync(x => x.CateId == id);
        }
        public async Task<int> UpdateCategoryInfoAsync(CategoryInfo categoryInfo)
        {
            if (CategoryInfoExists(categoryInfo.CateId))
            {
                _context.Entry(categoryInfo).State = EntityState.Modified;
            }
            else
            {
            }
            return await _context.SaveChangesAsync();
        }
        public async Task<int> CreateCategoryInfoAsync(CategoryInfo categoryInfo)
        {
            _context.CategoryInfos.Add(categoryInfo);
            return await _context.SaveChangesAsync();
        }


        public async Task<int> DeleteCategoryInfoAsync(string id)
        {

            if (CategoryInfoExists(id))
            {
                var categoryInfo = await _context.CategoryInfos.FirstOrDefaultAsync(x => x.CateId == id);
                _context.CategoryInfos.Remove(categoryInfo);
            }
            return await _context.SaveChangesAsync();
        }

        private bool CategoryInfoExists(string id)
        {
            return _context.CategoryInfos.Any(e => e.CateId == id);
        }
        #endregion
    }
}