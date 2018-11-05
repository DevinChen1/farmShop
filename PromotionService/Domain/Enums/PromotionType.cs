using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionService.Domain.Enums
{
    /// <summary>
    /// 促销活动类型
    /// </summary>
    public enum PromotionType
    {
        /// <summary>
        /// 买送促销活动信息类
        /// </summary>
        BuySend = 0,
        /// <summary>
        /// 满赠促销活动信息类
        /// </summary>
        FullSend = 1,
        /// <summary>
        /// 满减促销活动信息类
        /// </summary>
        FullCut = 2,
          /// <summary>
          /// 单品促销活动信息类
          /// </summary>
    Single,
    }
}
