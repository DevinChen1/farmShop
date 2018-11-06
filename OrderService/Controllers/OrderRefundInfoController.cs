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
    public class OrderRefundInfoController : ControllerBase
    {
        private OrderRefundInfoAppService _orderRefundInfoAppService;
        public OrderRefundInfoController(OrderRefundInfoAppService orderRefundInfoAppService) {
            this._orderRefundInfoAppService=  orderRefundInfoAppService;
        }
        // GET: api/OrderRefundInfo
        [HttpGet]
        public IEnumerable<OrderRefundInfo> GetOrderRefundInfoList()
        {
            return _orderRefundInfoAppService.GetOrderRefundInfoList();
        }

        // GET: api/OrderRefundInfo/5
        [HttpGet]
        public async Task< OrderRefundInfo> GetOrderRefundInfo(string id)
        {
            return await _orderRefundInfoAppService.GetOrderRefundInfoAsync(id);
        }
        // POST: api/OrderRefundInfo
        [HttpPost]
        public async Task<int> CreateOrderRefundInfo(OrderRefundInfo OrderRefundInfo)
        {
            return await _orderRefundInfoAppService.CreateOrderRefundInfoAsync(OrderRefundInfo);
        }
        // POST: api/UpdateOrderRefundInfo
        [HttpPost]
        public async Task<int> UpdateOrderRefundInfo(OrderRefundInfo OrderRefundInfo)
        {
            return await _orderRefundInfoAppService.UpdateOrderRefundInfoAsync(OrderRefundInfo);
        }


        // POST: api/DeleteOrderRefundInfo
        [HttpPost]
        public async Task<int> DeleteOrderRefundInfo(string id)
        {
            return await _orderRefundInfoAppService.DeleteOrderRefundInfoAsync(id);
        }


    }
}
