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
  
    public class OrderAfterServiceInfoAppService  
    {
        private readonly OrderDBContext _context;

        public OrderAfterServiceInfoAppService(OrderDBContext context)
        {
            _context = context;
        }
         

        #region OrderAfterServiceInfo 操作
        public IEnumerable<OrderAfterServiceInfo> GetOrderAfterServiceInfoList()
        {
            return _context.OrderAfterServiceInfos;
        }
       
        public async Task<OrderAfterServiceInfo> GetOrderAfterServiceInfoAsync(string id)
        {
            return await _context.OrderAfterServiceInfos.FirstOrDefaultAsync(x => x.ASId == id);
        }
        public async Task<int> UpdateOrderAfterServiceInfoAsync(OrderAfterServiceInfo OrderAfterServiceInfo)
        {
            if (OrderAfterServiceInfoExists(OrderAfterServiceInfo.ASId))
            {
                _context.Entry(OrderAfterServiceInfo).State = EntityState.Modified;
            }
            else
            {
            }
            return await _context.SaveChangesAsync();
        }
        public async Task<int> CreateOrderAfterServiceInfoAsync(OrderAfterServiceInfo OrderAfterServiceInfo)
        {
            _context.OrderAfterServiceInfos.Add(OrderAfterServiceInfo);
            return await _context.SaveChangesAsync();
        }


        public async Task<int> DeleteOrderAfterServiceInfoAsync(string id)
        {

            if (OrderAfterServiceInfoExists(id))
            {
                var OrderAfterServiceInfo = await _context.OrderAfterServiceInfos.FirstOrDefaultAsync(x => x.ASId == id);
                _context.OrderAfterServiceInfos.Remove(OrderAfterServiceInfo);
            }
            return await _context.SaveChangesAsync();
        }

        private bool OrderAfterServiceInfoExists(string id)
        {
            return _context.OrderAfterServiceInfos.Any(e => e.ASId == id);
        }
        #endregion
    }
}