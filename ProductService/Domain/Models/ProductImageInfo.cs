using System;
using System.ComponentModel.DataAnnotations;

namespace ProductService.Domain.Models
{
    /// <summary>
    /// 商品图片信息类
    /// </summary>
    public class ProductImageInfo
    {
        /// <summary>
        /// 商品图片id
        /// </summary>
        [Key]
        public string PImgId { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        public string Pid { get; set; }
        /// <summary>
        /// 商品图片
        /// </summary>
        public string ShowImg { get; set; }
        /// <summary>
        /// 是否为主图
        /// </summary>
        public bool IsMain { get; set; } = false;
        /// <summary>
        /// 商品图片排序
        /// </summary>
        public int DisplayOrder { get; set; } = 0;
    }
}
