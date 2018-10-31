using System;

namespace ProductService.Domain.Models
{
    /// <summary>
    /// 分类信息类
    /// </summary>
	public class CategoryInfo
    {


        /// <summary>
        /// 分类id
        /// </summary>
        public int CateId { set; get; }//分类id
        /// <summary>
        /// 分类排序
        /// </summary>
        public int DisplayOrder { set; get; }
        /// <summary>
        /// 分类名称
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 分类价格范围
        /// </summary>
        public string PriceRange { set; get; }
        /// <summary>
        /// 父id
        /// </summary>
        public int ParentId { set; get; }
        /// <summary>
        /// 层级
        /// </summary>
        public int Layer { set; get; }
        /// <summary>
        /// 是否有子节点
        /// </summary>
        public int HasChild { set; get; }
        /// <summary>
        /// 分类路径
        /// </summary>
        public string Path { set; get; }

    }
}

