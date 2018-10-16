using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressService.Models
{
    /// <summary>
    /// 用户配送地址信息类
    /// </summary>
    public class ShipAddressInfo
    {
        /// <summary>
        /// 配送地址id
        /// </summary>
        public string id{get;set;}//配送地址id
        /// <summary>
        /// 用户id
        /// </summary>
        public string uid {get;set;}//用户id
        /// <summary>
        /// 区域id
        /// </summary>
        public string regionid {get;set;}//区域id
        /// <summary>
        /// 是否是默认地址
        /// </summary>
        public bool isdefault{get;set;}//是否是默认地址
        /// <summary>
        /// 别名
        /// </summary>
        public string alias{get;set;}//别名
        /// <summary>
        /// 收货人
        /// </summary>
        public string consignee{get;set;}//收货人
        /// <summary>
        /// 收货人手机
        /// </summary>
        public string mobile{get;set;}//收货人手机
        /// <summary>
        /// 收货人固定电话
        /// </summary>
        public string phone{get;set;}//收货人固定电话
        /// <summary>
        /// 收货人邮箱
        /// </summary>
        public string email{get;set;}//收货人邮箱
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string zipcode{get;set;}//邮政编码
        /// <summary>
        /// 地址
        /// </summary>
        public string address{get;set;}//地址
        /// <summary>
        /// 省id
        /// </summary>
        public string provinceid {get;set;}//省id
        /// <summary>
        /// 省名称
        /// </summary>
        public string provincename{get;set;}//省名称
        /// <summary>
        /// 市id
        /// </summary>
        public string cityid {get;set;}//市id
        /// <summary>
        /// 市名称
        /// </summary>
        public string cityname{get;set;}//市名称
        /// <summary>
        /// 县或区id
        /// </summary>
        public string countyid {get;set;}//县或区id
        /// <summary>
        /// 县或区名称
        /// </summary>
        public string countyname{get;set;}//县或区名称
    }
}
