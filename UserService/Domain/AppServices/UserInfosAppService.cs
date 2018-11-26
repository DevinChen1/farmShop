using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserService;
using UserService.Domain.Models;

namespace UserService.Domain.AppServices
{
   
    public class UserInfosAppService  
    {
        private readonly UserDBContext _context;
        public UserInfosAppService(UserDBContext context)
        {
            _context = context;
        }
        public IEnumerable<UserInfo> GetUserInfos()
        {
            return _context.UserInfos;
        }
        public async Task<UserInfo> GetUserInfoAsync(string id)
        {
            return await _context.UserInfos.FirstOrDefaultAsync(x => x.Uid == id);
        }
        public async Task<int> UpdateUserInfoAsync( UserInfo userInfo)
        {
                if (UserInfoExists(userInfo.Uid))
                {
                    _context.Entry(userInfo).State = EntityState.Modified;
                }
                else
                {
                }
            return await _context.SaveChangesAsync();
        }
        public async Task<int> CreateUserInfoAsync( UserInfo userInfo)
        {
            _context.UserInfos.Add(userInfo);
            return await _context.SaveChangesAsync();
        }

    
        public async Task<int> DeleteUserInfoAsync(  string uid)
        {
            var userInfo = await _context.UserInfos.FirstOrDefaultAsync(x=>x.Uid==uid);
            _context.UserInfos.Remove(userInfo);
            return await _context.SaveChangesAsync();
        }

        private bool UserInfoExists(string id)
        {
            return _context.UserInfos.Any(e => e.Uid == id);
        }
    }
}