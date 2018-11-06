using OrderService.Domain.Enums;
using System;

namespace OrderService.Domain.Models
{
    /// <summary>
    /// 订单退款信息类
    /// </summary>
    public class OrderRefundInfo
    {
    
        /// <summary>
        /// 退款id
        /// </summary>
        public string RefundId { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public OrderRefundState State { get; set; } = OrderRefundState.Applied;
        /// <summary>
        /// 订单id
        /// </summary>
        public string Oid { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string OSN { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public string Uid { get; set; }
        /// <summary>
        /// 售后服务id
        /// </summary>
        public string ASId { get; set; }
        /// <summary>
        /// 支付方式系统名
        /// </summary>
        public string PaySystemName { get; set; }
        /// <summary>
        /// 支付方式昵称
        /// </summary>
        public string PayFriendName { get; set; }
        /// <summary>
        /// 支付单号
        /// </summary>
        public string PaySN { get; set; }
        /// <summary>
        /// 支付金额
        /// </summary>
        public decimal PayMoney { get; set; }
        /// <summary>
        /// 退款金额
        /// </summary>
        public decimal RefundMoney { get; set; }
        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime ApplyTime { get; set; }
        /// <summary>
        /// 退款单号
        /// </summary>
        public string RefundSN { get; set; }
        /// <summary>
        /// 退款时间
        /// </summary>
        public DateTime RefundTime { get; set; }
    }
}
