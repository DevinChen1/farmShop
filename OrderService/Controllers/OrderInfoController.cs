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
    public class OrderInfoController : ControllerBase
    {
        private OrderInfoAppService _orderInfoAppService;
        public OrderInfoController(OrderInfoAppService orderInfoAppService) {
            this._orderInfoAppService=  orderInfoAppService;
        }
        // GET: api/OrderInfo
        [HttpGet]
        public IEnumerable<OrderInfo> GetOrderInfoList()
        {
            return _orderInfoAppService.GetOrderInfoList();
        }

        // GET: api/OrderInfo/5
        [HttpGet]
        public async Task< OrderInfo> GetOrderInfo(string id)
        {
            return await _orderInfoAppService.GetOrderInfoAsync(id);
        }
        // POST: api/OrderInfo
        [HttpPost]
        public async Task<int> CreateOrderInfo(OrderInfo OrderInfo)
        {
            return await _orderInfoAppService.CreateOrderInfoAsync(OrderInfo);
        }
        // POST: api/UpdateOrderInfo
        [HttpPost]
        public async Task<int> UpdateOrderInfo(OrderInfo OrderInfo)
        {
            return await _orderInfoAppService.UpdateOrderInfoAsync(OrderInfo);
        }


        // POST: api/DeleteOrderInfo
        [HttpPost]
        public async Task<int> DeleteOrderInfo(string id)
        {
            return await _orderInfoAppService.DeleteOrderInfoAsync(id);
        }


    }
}
