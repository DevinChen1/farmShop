using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopService;
using ShopService.Domain.Models;

namespace ShopService.Domain.AppServices
{

    public class ShopInfoesAppService
    {
        private readonly ShopDBContext _context;

        public ShopInfoesAppService(ShopDBContext context)
        {
            _context = context;
        }
        public IEnumerable<ShopInfo> GetShopInfos()
        {
            return _context.ShopInfos;
        }


        public async Task<ShopInfo> GetShopInfoAsync(string shopId)
        {
            return await _context.ShopInfos.FirstOrDefaultAsync(x => x.ShopId == shopId);
        }

        public async Task<int> UpdateShopInfoAsync(ShopInfo shopInfo)
        {
            if (ShopInfoExists(shopInfo.ShopId))
            {
                _context.Entry(shopInfo).State = EntityState.Modified;
            }
            else
            {
                _context.Add(shopInfo);
            }
            return await _context.SaveChangesAsync();
        }
        public async Task<int> CreateShopInfoAsync(  ShopInfo shopInfo)
        {
            _context.ShopInfos.Add(shopInfo);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> DeleteShopInfoAsync( string shopId)
        {
            var shopInfo = await _context.ShopInfos.FirstOrDefaultAsync(x=>x.ShopId== shopId);
            _context.ShopInfos.Remove(shopInfo);
            return await _context.SaveChangesAsync();
        }
        private bool ShopInfoExists(string id)
        {
            return _context.ShopInfos.Any(e => e.ShopId == id);
        }
    }
}