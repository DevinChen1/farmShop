using System;

namespace PromotionService.Domain.Models
{
    /// <summary>
    /// 满减促销活动信息类
    /// </summary>
    public class FullCutPromotionInfo
    {
       

        /// <summary>
        /// 活动id
        /// </summary>
        public int PmId { get; set; }
        /// <summary>
        /// 活动类型,0代表全场商品满减，1代表部分商品满减，2代表部分商品不满减
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 用户等级下限
        /// </summary>
        public int UserRankLower { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 限制金额1
        /// </summary>
        public int LimitMoney1 { get; set; }
        /// <summary>
        /// 减小金额1
        /// </summary>
        public int CutMoney1 { get; set; }
        /// <summary>
        /// 限制金额2
        /// </summary>
        public int LimitMoney2 { get; set; }
        /// <summary>
        /// 减小金额2
        /// </summary>
        public int CutMoney2 { get; set; }
        /// <summary>
        /// 限制金额3
        /// </summary>
        public int LimitMoney3 { get; set; }
        /// <summary>
        /// 减小金额3
        /// </summary>
        public int CutMoney3 { get; set; }
    }
}
