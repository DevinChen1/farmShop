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
    public class OrderActionInfoController : ControllerBase
    {
        private OrderActionInfoAppService _orderActionInfoAppService;
        public OrderActionInfoController(OrderActionInfoAppService orderActionInfoAppService) {
            this._orderActionInfoAppService=  orderActionInfoAppService;
        }
        // GET: api/OrderActionInfo
        [HttpGet]
        public IEnumerable<OrderActionInfo> GetOrderActionInfoList()
        {
            return _orderActionInfoAppService.GetOrderActionInfoList();
        }

        // GET: api/OrderActionInfo/5
        [HttpGet]
        public async Task< OrderActionInfo> GetOrderActionInfo(string id)
        {
            return await _orderActionInfoAppService.GetOrderActionInfoAsync(id);
        }
        // POST: api/OrderActionInfo
        [HttpPost]
        public async Task<int> CreateOrderActionInfo(OrderActionInfo OrderActionInfo)
        {
            return await _orderActionInfoAppService.CreateOrderActionInfoAsync(OrderActionInfo);
        }
        // POST: api/UpdateOrderActionInfo
        [HttpPost]
        public async Task<int> UpdateOrderActionInfo(OrderActionInfo OrderActionInfo)
        {
            return await _orderActionInfoAppService.UpdateOrderActionInfoAsync(OrderActionInfo);
        }


        // POST: api/DeleteOrderActionInfo
        [HttpPost]
        public async Task<int> DeleteOrderActionInfo(string id)
        {
            return await _orderActionInfoAppService.DeleteOrderActionInfoAsync(id);
        }


    }
}
