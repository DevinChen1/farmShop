using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderService.Domain.Models;

namespace OrderService.Domain.AppServices
{
  
    public class OrderInfoAppService  
    {
        private readonly OrderDBContext _context;

        public OrderInfoAppService(OrderDBContext context)
        {
            _context = context;
        }
         

        #region OrderInfo 操作
        public IEnumerable<OrderInfo> GetOrderInfoList()
        {
            return _context.OrderInfos;
        }
       
        public async Task<OrderInfo> GetOrderInfoAsync(string id)
        {
            return await _context.OrderInfos.FirstOrDefaultAsync(x => x.Oid == id);
        }
        public async Task<int> UpdateOrderInfoAsync(OrderInfo OrderInfo)
        {
            if (OrderInfoExists(OrderInfo.Oid))
            {
                _context.Entry(OrderInfo).State = EntityState.Modified;
            }
            else
            {
            }
            return await _context.SaveChangesAsync();
        }
        public async Task<int> CreateOrderInfoAsync(OrderInfo OrderInfo)
        {
            _context.OrderInfos.Add(OrderInfo);
            return await _context.SaveChangesAsync();
        }


        public async Task<int> DeleteOrderInfoAsync(string id)
        {

            if (OrderInfoExists(id))
            {
                var OrderInfo = await _context.OrderInfos.FirstOrDefaultAsync(x => x.Oid == id);
                _context.OrderInfos.Remove(OrderInfo);
            }
            return await _context.SaveChangesAsync();
        }

        private bool OrderInfoExists(string id)
        {
            return _context.OrderInfos.Any(e => e.Oid == id);
        }
        #endregion
    }
}