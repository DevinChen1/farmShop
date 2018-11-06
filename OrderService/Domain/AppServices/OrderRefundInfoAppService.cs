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
  
    public class OrderRefundInfoAppService  
    {
        private readonly OrderDBContext _context;

        public OrderRefundInfoAppService(OrderDBContext context)
        {
            _context = context;
        }
         

        #region OrderRefundInfo 操作
        public IEnumerable<OrderRefundInfo> GetOrderRefundInfoList()
        {
            return _context.OrderRefundInfos;
        }
       
        public async Task<OrderRefundInfo> GetOrderRefundInfoAsync(string id)
        {
            return await _context.OrderRefundInfos.FirstOrDefaultAsync(x => x.RefundId == id);
        }
        public async Task<int> UpdateOrderRefundInfoAsync(OrderRefundInfo OrderRefundInfo)
        {
            if (OrderRefundInfoExists(OrderRefundInfo.RefundId))
            {
                _context.Entry(OrderRefundInfo).State = EntityState.Modified;
            }
            else
            {
            }
            return await _context.SaveChangesAsync();
        }
        public async Task<int> CreateOrderRefundInfoAsync(OrderRefundInfo OrderRefundInfo)
        {
            _context.OrderRefundInfos.Add(OrderRefundInfo);
            return await _context.SaveChangesAsync();
        }


        public async Task<int> DeleteOrderRefundInfoAsync(string id)
        {

            if (OrderRefundInfoExists(id))
            {
                var OrderRefundInfo = await _context.OrderRefundInfos.FirstOrDefaultAsync(x => x.RefundId == id);
                _context.OrderRefundInfos.Remove(OrderRefundInfo);
            }
            return await _context.SaveChangesAsync();
        }

        private bool OrderRefundInfoExists(string id)
        {
            return _context.OrderRefundInfos.Any(e => e.RefundId == id);
        }
        #endregion
    }
}