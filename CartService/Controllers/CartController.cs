using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartService.Domain.AppServices;
using CartService.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CartService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private CartProductInfoesAppService _cartProductInfoesAppService;
        public CartController(CartProductInfoesAppService cartProductInfoesAppService)
        {
            this._cartProductInfoesAppService = cartProductInfoesAppService;
        }
        [HttpGet]
        public IEnumerable<CartProductInfo> GetCartProductInfos(string uid)
        {
          return  _cartProductInfoesAppService.GetCartProductInfos(uid);
        }
  
        [HttpPost]
        public async Task<int> AddCartProductInfo(CartProductInfo cartProductInfo)
        {
          return await _cartProductInfoesAppService.AddCartProductInfoAsync(cartProductInfo);
        }
        [HttpPost]
        public async Task<int> RemoveCartProductInfo(CartProductInfo cartProductInfo)
        {
            return await _cartProductInfoesAppService.RemoveCartProductInfo(cartProductInfo);
        }
        [HttpPost]
        public async Task<int> RemoveAllCartProductInfoWithPid(CartProductInfo cartProductInfo)
        {
            return await _cartProductInfoesAppService.RemoveAllCartProductInfoWithPid(cartProductInfo.Pid);
        }
        [HttpPost]
        public async Task<int> ClearCart(string uid)
        {
            return await _cartProductInfoesAppService.ClearCartAsync(uid);
        }
   
    }
}
