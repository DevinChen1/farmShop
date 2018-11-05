using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CartService;
using CartService.Domain.Models;

namespace CartService.Domain.AppServices
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartProductInfoesAppService
    {
        private readonly CartDBContext _context;

        public CartProductInfoesAppService(CartDBContext context)
        {
            _context = context;
        }

        public IEnumerable<CartProductInfo> GetCartProductInfos(string uid)
        {
            return _context.CartProductInfos.Where(x => x.Uid == uid);
        }
        public async Task<int> AddCartProductInfoAsync(CartProductInfo cartProductInfo)
        {
            if (CartProductInfoExists(cartProductInfo.Pid))
            {
               var entity= _context.CartProductInfos.FirstOrDefault(x=>x.Pid== cartProductInfo.Pid);
                entity.CartCount+= cartProductInfo.CartCount;
            }
            else
            {
                await _context.CartProductInfos.AddAsync(cartProductInfo);
            }
            return await _context.SaveChangesAsync();
        }
        public async Task<int> RemoveCartProductInfo(CartProductInfo cartProductInfo)
        {
            if (CartProductInfoExists(cartProductInfo.Pid))
            {
                var entity = _context.CartProductInfos.FirstOrDefault(x => x.Pid == cartProductInfo.Pid);
                entity.CartCount--;
            }
            else
            {
                await _context.CartProductInfos.AddAsync(cartProductInfo);
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<int> RemoveAllCartProductInfoWithPid(string pid)
        {
           var cartProductInfos= _context.CartProductInfos.Where(x => x.Pid == pid);
            _context.RemoveRange(cartProductInfos);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> ClearCartAsync(string uid)
        {
            var cartProductInfos = _context.CartProductInfos.Where(x => x.Uid == uid);
            _context.CartProductInfos.RemoveRange(cartProductInfos);
            return await _context.SaveChangesAsync();
        }

        private bool CartProductInfoExists(string Pid)
        {
            return _context.CartProductInfos.Any(e => e.Pid == Pid);
        }
    }
}