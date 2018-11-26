using System;
using System.ComponentModel.DataAnnotations;

namespace AdminService.Domain.Models
{
    /// <summary>
    /// 后台操作信息类
    /// </summary>
    public class  ActionInfo
    {
 
        /// <summary>
        /// 操作id
        /// </summary>
        [Key]
        public int Aid { get; set; }
        /// <summary>
        /// 操作标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 操作行为
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// 父id
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
