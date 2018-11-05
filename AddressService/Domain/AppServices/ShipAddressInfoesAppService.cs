using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AddressService;
using AddressService.Domain.Models;

namespace AddressService.Domain.AppServices
{

    public class ShipAddressInfoesAppService 
    {
        private readonly AddressDBContext _context;

        public ShipAddressInfoesAppService(AddressDBContext context)
        {
            _context = context;
        }
   
        public IEnumerable<ShipAddressInfo> GetShipAddressInfos(string  uid)
        {
            return _context.ShipAddressInfos.Where(x=>x.Uid==uid);
        }
        public async Task<ShipAddressInfo> GetShipAddressInfoAsync(string saId)
        {
            return await _context.ShipAddressInfos.FirstOrDefaultAsync(X=>X.SAId==saId);
        }
        public async Task<int> UpdateShipAddressInfoAsync(ShipAddressInfo shipAddressInfo)
        {
            _context.Entry(shipAddressInfo).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }
        public async Task<bool> UpdateShipAddressIsDefaultAsync(ShipAddressInfo shipAddressInfo)
        {
            await _context.ShipAddressInfos.Where(x => x.Uid == shipAddressInfo.Uid).ForEachAsync(i => i.IsDefault = false);
            shipAddressInfo.IsDefault = true;
            _context.Entry(shipAddressInfo).State = EntityState.Modified;
            var result = await _context.SaveChangesAsync();
            return result >= 0 ? true : false;
        }
        public async Task<int> CreateShipAddressInfoAsync(ShipAddressInfo shipAddressInfo)
        {
            _context.ShipAddressInfos.Add(shipAddressInfo);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> DeleteShipAddressInfoAsync(string id)
        {
            var shipAddressInfo = await _context.ShipAddressInfos.FindAsync(id);
            _context.ShipAddressInfos.Remove(shipAddressInfo);
            return await _context.SaveChangesAsync();
        }
        private bool ShipAddressInfoExists(string id)
        {
            return _context.ShipAddressInfos.Any(e => e.SAId == id);
        }
    }
}