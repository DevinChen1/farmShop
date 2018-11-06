using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopService.Domain.AppServices;
using ShopService.Domain.Models;

namespace ShopService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private ShopInfoesAppService _shopInfoesAppService;
        public ShopController(ShopInfoesAppService shopInfoesAppService)
        {
            this._shopInfoesAppService = shopInfoesAppService;
        }
        // GET: api/Shop
        [HttpGet]
        public IEnumerable<ShopInfo> GetAll()
        {
           return _shopInfoesAppService.GetShopInfos();
        }

        // GET: api/Shop/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ShopInfo> Get(string shopid)
        {
            return await _shopInfoesAppService.GetShopInfoAsync(shopid);
        }

        // POST: api/Shop
        [HttpPost]
        public async Task<int> Create(ShopInfo shopInfo)
        {
            return await _shopInfoesAppService.CreateShopInfoAsync(shopInfo);
        }

        [HttpPost]
        public async Task<int> Update(ShopInfo shopInfo)
        {
            return await _shopInfoesAppService.UpdateShopInfoAsync(shopInfo);
        }

        // DELETE: api/ApiWithActions/5
        [HttpPost]
        public async Task<int> Delete(string shoipid)
        {
            return await _shopInfoesAppService.DeleteShopInfoAsync(shoipid);
        }
    }
}
