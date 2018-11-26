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
  
    public class OrderActionInfoAppService  
    {
        private readonly OrderDBContext _context;

        public OrderActionInfoAppService(OrderDBContext context)
        {
            _context = context;
        }
         

        #region OrderActionInfo 操作
        public IEnumerable<OrderActionInfo> GetOrderActionInfoList()
        {
            return _context.OrderActionInfos;
        }
       
        public async Task<OrderActionInfo> GetOrderActionInfoAsync(string id)
        {
            return await _context.OrderActionInfos.FirstOrDefaultAsync(x => x.Aid == id);
        }
        public async Task<int> UpdateOrderActionInfoAsync(OrderActionInfo OrderActionInfo)
        {
            if (OrderActionInfoExists(OrderActionInfo.Aid))
            {
                _context.Entry(OrderActionInfo).State = EntityState.Modified;
            }
            else
            {
            }
            return await _context.SaveChangesAsync();
        }
        public async Task<int> CreateOrderActionInfoAsync(OrderActionInfo OrderActionInfo)
        {
            _context.OrderActionInfos.Add(OrderActionInfo);
            return await _context.SaveChangesAsync();
        }


        public async Task<int> DeleteOrderActionInfoAsync(string id)
        {

            if (OrderActionInfoExists(id))
            {
                var OrderActionInfo = await _context.OrderActionInfos.FirstOrDefaultAsync(x => x.Aid == id);
                _context.OrderActionInfos.Remove(OrderActionInfo);
            }
            return await _context.SaveChangesAsync();
        }

        private bool OrderActionInfoExists(string id)
        {
            return _context.OrderActionInfos.Any(e => e.Aid == id);
        }
        #endregion
    }
}