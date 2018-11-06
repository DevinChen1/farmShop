using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService.Domain.Models
{
    public class ShopInfo
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [Key]
        public string ShopId { get; set; }
        /// <summary>
        /// 门店编号
        /// </summary>
        public string ShopSN { get; set; }
        /// <summary>
        /// 门店负责人id
        /// </summary>
        public string LeaderUid { get; set; }
        /// <summary>
        /// 门店负责人名称
        /// </summary>
        public string LeaderName { get; set; }
        /// <summary>
        /// 门店负责人电话
        /// </summary>
        public string LeaderPhone { get; set; }
        /// <summary>
        /// 门店图片
        /// </summary>
        public string ShopImg { get; set; }
        /// <summary>
        /// 门店固话号
        /// </summary>
        public string ShopTel { get; set; }
        /// <summary>
        /// 门店区域id
        /// </summary>
        public int RegionId { get; set; }
        /// <summary>
        /// 门店区域id
        /// </summary>
        public int RegionStr { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 商店备注
        /// </summary>
        public string ShopRemark { get; set; } = "营业时间：早上6：00 至 晚上9：00！";
        /// <summary>
        /// 开店时间
        /// </summary>
        public DateTime OpenShopTime { get; set; }
        /// <summary>
        /// 关店时间
        /// </summary>
        public  DateTime CloseShopTime { get; set; }
        /// <summary>
        /// 店铺成立时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// ip地址
        /// </summary>
        public string IP { get; set; }
    }
}
