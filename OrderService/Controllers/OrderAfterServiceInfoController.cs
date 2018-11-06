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
    public class OrderAfterServiceInfoController : ControllerBase
    {
        private OrderAfterServiceInfoAppService _orderAfterServiceInfoAppService;
        public OrderAfterServiceInfoController(OrderAfterServiceInfoAppService orderAfterServiceInfoAppService) {
            this._orderAfterServiceInfoAppService=  orderAfterServiceInfoAppService;
        }
        // GET: api/OrderAfterServiceInfo
        [HttpGet]
        public IEnumerable<OrderAfterServiceInfo> GetOrderAfterServiceInfoList()
        {
            return _orderAfterServiceInfoAppService.GetOrderAfterServiceInfoList();
        }

        // GET: api/OrderAfterServiceInfo/5
        [HttpGet]
        public async Task< OrderAfterServiceInfo> GetOrderAfterServiceInfo(string id)
        {
            return await _orderAfterServiceInfoAppService.GetOrderAfterServiceInfoAsync(id);
        }
        // POST: api/OrderAfterServiceInfo
        [HttpPost]
        public async Task<int> CreateOrderAfterServiceInfo(OrderAfterServiceInfo OrderAfterServiceInfo)
        {
            return await _orderAfterServiceInfoAppService.CreateOrderAfterServiceInfoAsync(OrderAfterServiceInfo);
        }
        // POST: api/UpdateOrderAfterServiceInfo
        [HttpPost]
        public async Task<int> UpdateOrderAfterServiceInfo(OrderAfterServiceInfo OrderAfterServiceInfo)
        {
            return await _orderAfterServiceInfoAppService.UpdateOrderAfterServiceInfoAsync(OrderAfterServiceInfo);
        }


        // POST: api/DeleteOrderAfterServiceInfo
        [HttpPost]
        public async Task<int> DeleteOrderAfterServiceInfo(string id)
        {
            return await _orderAfterServiceInfoAppService.DeleteOrderAfterServiceInfoAsync(id);
        }


    }
}
