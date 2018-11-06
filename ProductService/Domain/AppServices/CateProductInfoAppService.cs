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
  
    public class CateProductInfoAppService
    {
        private readonly ProductDBContext _context;

        public CateProductInfoAppService(ProductDBContext context)
        {
            _context = context;
        }


        #region CateProductInfo 操作
        public IEnumerable<CateProductInfo> GetCateProductInfoList()
        {
            return _context.CateProductInfos;
        }
       
        public async Task<CateProductInfo> GetCateProductInfoAsync(string id)
        {
            return await _context.CateProductInfos.FirstOrDefaultAsync(x => x.CateId == id);
        }
        public async Task<int> UpdateCateProductInfoAsync(CateProductInfo CateProductInfo)
        {
            if (CateProductInfoExists(CateProductInfo.CateId))
            {
                _context.Entry(CateProductInfo).State = EntityState.Modified;
            }
            else
            {
            }
            return await _context.SaveChangesAsync();
        }
        public async Task<int> CreateCateProductInfoAsync(CateProductInfo CateProductInfo)
        {
            _context.CateProductInfos.Add(CateProductInfo);
            return await _context.SaveChangesAsync();
        }


        public async Task<int> DeleteCateProductInfoAsync(string id)
        {

            if (CateProductInfoExists(id))
            {
                var CateProductInfo = await _context.CateProductInfos.FirstOrDefaultAsync(x => x.CateId == id);
                _context.CateProductInfos.Remove(CateProductInfo);
            }
            return await _context.SaveChangesAsync();
        }

        private bool CateProductInfoExists(string id)
        {
            return _context.CateProductInfos.Any(e => e.CateId == id);
        }
        #endregion
    }
}