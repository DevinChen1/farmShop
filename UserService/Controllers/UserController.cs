using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Domain.AppServices;
using UserService.Domain.Models;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserInfosAppService _userInfoesAppService;
        public UserController(UserInfosAppService userInfoesAppService)
        {
            this._userInfoesAppService = userInfoesAppService;
        }
        // GET: api/User
        [HttpGet]
        public IEnumerable<UserInfo> Get()
        {
            return _userInfoesAppService.GetUserInfos();
        }
        // GET: api/User/5
        [HttpGet]
        public async Task<UserInfo> Get(string id)
        {
            return await _userInfoesAppService.GetUserInfoAsync(id);
        }

        // POST: api/User
        [HttpPost]
        public async Task<int> Create(UserInfo userInfo)
        {
            return await _userInfoesAppService.CreateUserInfoAsync(userInfo);
        }
        // POST: api/User
        [HttpPost]
        public async Task<int> Update(UserInfo userInfo)
        {
            return await _userInfoesAppService.UpdateUserInfoAsync(userInfo);
        }
        // POST: api/User
        [HttpPost]
        public async Task<int> Create(string uid)
        {
            return await _userInfoesAppService.DeleteUserInfoAsync(uid);

        }




        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
