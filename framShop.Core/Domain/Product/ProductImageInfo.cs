﻿using System;
using System.ComponentModel.DataAnnotations;

namespace framShop.Core
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
        public int PImgId { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        public int Pid { get; set; }
        /// <summary>
        /// 商品图片
        /// </summary>
        public string ShowImg { get; set; }
        /// <summary>
        /// 是否为主图
        /// </summary>
        public int IsMain { get; set; }
        /// <summary>
        /// 商品图片排序
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
