using System;
using System.ComponentModel.DataAnnotations;

namespace AdminService.Domain.Models
{
    /// <summary>
    /// 管理员组信息类
    /// </summary>
    public class AdminGroupInfo
    {



        /// <summary>
        /// 管理员组id
        /// </summary>
        [Key]
        public string AdminGid { get; set; }

        /// <summary>
        /// 管理员组标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 管理员组行为列表
        /// </summary>
        public string ActionList { get; set; }
    }
}
