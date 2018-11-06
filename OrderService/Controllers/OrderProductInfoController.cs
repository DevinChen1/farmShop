using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Domain.AppServices;
using OrderService.Domain.Models;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderProductInfoController : ControllerBase
    {
        private OrderProductInfoAppService _orderProductInfoAppService;
        public OrderProductInfoController(OrderProductInfoAppService orderProductInfoAppService) {
            this._orderProductInfoAppService=  orderProductInfoAppService;
        }
        // GET: api/OrderProductInfo
        [HttpGet]
        public IEnumerable<OrderProductInfo> GetOrderProductInfoList()
        {
            return _orderProductInfoAppService.GetOrderProductInfoList();
        }

        // GET: api/OrderProductInfo/5
        [HttpGet]
        public async Task< OrderProductInfo> GetOrderProductInfo(string id)
        {
            return await _orderProductInfoAppService.GetOrderProductInfoAsync(id);
        }
        // POST: api/OrderProductInfo
        [HttpPost]
        public async Task<int> CreateOrderProductInfo(OrderProductInfo OrderProductInfo)
        {
            return await _orderProductInfoAppService.CreateOrderProductInfoAsync(OrderProductInfo);
        }
        // POST: api/UpdateOrderProductInfo
        [HttpPost]
        public async Task<int> UpdateOrderProductInfo(OrderProductInfo OrderProductInfo)
        {
            return await _orderProductInfoAppService.UpdateOrderProductInfoAsync(OrderProductInfo);
        }


        // POST: api/DeleteOrderProductInfo
        [HttpPost]
        public async Task<int> DeleteOrderProductInfo(string id)
        {
            return await _orderProductInfoAppService.DeleteOrderProductInfoAsync(id);
        }


    }
}
