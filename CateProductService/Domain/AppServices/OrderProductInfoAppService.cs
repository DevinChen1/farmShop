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
  
    public class OrderProductInfoAppService  
    {
        private readonly OrderDBContext _context;

        public OrderProductInfoAppService(OrderDBContext context)
        {
            _context = context;
        }
         

        #region OrderProductInfo 操作
        public IEnumerable<OrderProductInfo> GetOrderProductInfoList()
        {
            return _context.OrderProductInfos;
        }
       
        public async Task<OrderProductInfo> GetOrderProductInfoAsync(string id)
        {
            return await _context.OrderProductInfos.FirstOrDefaultAsync(x => x.RecordId == id);
        }
        public async Task<int> UpdateOrderProductInfoAsync(OrderProductInfo OrderProductInfo)
        {
            if (OrderProductInfoExists(OrderProductInfo.RecordId))
            {
                _context.Entry(OrderProductInfo).State = EntityState.Modified;
            }
            else
            {
            }
            return await _context.SaveChangesAsync();
        }
        public async Task<int> CreateOrderProductInfoAsync(OrderProductInfo OrderProductInfo)
        {
            _context.OrderProductInfos.Add(OrderProductInfo);
            return await _context.SaveChangesAsync();
        }


        public async Task<int> DeleteOrderProductInfoAsync(string id)
        {

            if (OrderProductInfoExists(id))
            {
                var OrderProductInfo = await _context.OrderProductInfos.FirstOrDefaultAsync(x => x.RecordId == id);
                _context.OrderProductInfos.Remove(OrderProductInfo);
            }
            return await _context.SaveChangesAsync();
        }

        private bool OrderProductInfoExists(string id)
        {
            return _context.OrderProductInfos.Any(e => e.RecordId == id);
        }
        #endregion
    }
}