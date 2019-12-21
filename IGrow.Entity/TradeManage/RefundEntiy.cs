using System;

namespace IGrow.Entity.TradeManage
{/// <summary>
/// 退款
/// </summary>
    public class RefundEntity : IEntity<RefundEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        /// <summary>
        /// 
        /// </summary>
        public string IGrowID { get; set; }
        /// <summary>
        /// 退款编号
        /// </summary>
        public string OnRefund00 { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string OnRefund01 { get; set; }
        /// <summary>
        ///  支付宝交易号
        /// </summary>
        public string OnRefund02 { get; set; }
        /// <summary>
        ///  订单付款时间
        /// </summary>
        public DateTime? OnRefund03 { get; set; }
        /// <summary>
        ///  商品编码
        /// </summary>
        public string OnRefund04 { get; set; }
        /// <summary>
        ///  退款完结时间
        /// </summary>
        public DateTime? OnRefund05 { get; set; }
        /// <summary>
        ///  买家会员名称
        /// </summary>
        public string OnRefund06 { get; set; }
        /// <summary>
        ///  买家实际支付金额
        /// </summary>
        public Double OnRefund07 { get; set; }
        /// <summary>
        ///  宝贝标题
        /// </summary>
        public string OnRefund08 { get; set; }
        /// <summary>
        ///  买家退款金额
        /// </summary>
        public Double OnRefund09 { get; set; }
        /// <summary>
        ///  手工退款/系统退款
        /// </summary>
        public string OnRefund10 { get; set; }
        /// <summary>
        ///  是否需要退货
        /// </summary>
        public string OnRefund11 { get; set; }
        /// <summary>
        ///  退款的申请时间
        /// </summary>
        public DateTime? OnRefund12 { get; set; }
        /// <summary>
        ///  超时时间
        /// </summary>
        public DateTime? OnRefund13 { get; set; }
        /// <summary>
        ///  退款状态
        /// </summary>
        public string OnRefund14 { get; set; }
        /// <summary>
        ///  货物状态
        /// </summary>
        public string OnRefund15 { get; set; }
        /// <summary>
        ///  退货物流信息
        /// </summary>
        public string OnRefund16 { get; set; }
        /// <summary>
        ///  发货物流信息
        /// </summary>
        public string OnRefund17 { get; set; }
        /// <summary>
        ///  客服介入状态
        /// </summary>
        public string OnRefund18 { get; set; }
        /// <summary>
        ///  卖家真实姓名
        /// </summary>
        public string OnRefund19 { get; set; }
        /// <summary>
        ///  卖家退货地址
        /// </summary>
        public string OnRefund20 { get; set; }
        /// <summary>
        ///  卖家邮编
        /// </summary>
        public string OnRefund21 { get; set; }
        /// <summary>
        ///  卖家电话
        /// </summary>
        public string OnRefund22 { get; set; }
        /// <summary>
        ///  卖家手机
        /// </summary>
        public string OnRefund23 { get; set; }
        /// <summary>
        ///  退货物流单号
        /// </summary>
        public string OnRefund24 { get; set; }
        /// <summary>
        ///  退货物流公司
        /// </summary>
        public string OnRefund25 { get; set; }
        /// <summary>
        ///  买家退款原因
        /// </summary>
        public string OnRefund26 { get; set; }
        /// <summary>
        ///  买家退款说明
        /// </summary>
        public string OnRefund27 { get; set; }
        /// <summary>
        ///  买家退货时间
        /// </summary>
        public string OnRefund28 { get; set; }
        /// <summary>
        ///  责任方
        /// </summary>
        public string OnRefund29 { get; set; }
        /// <summary>
        ///  售中或售后
        /// </summary>
        public string OnRefund30 { get; set; }
        /// <summary>
        ///  商家备注
        /// </summary>
        public string OnRefund31 { get; set; }
        /// <summary>
        ///  完结时间
        /// </summary>
        public string OnRefund32 { get; set; }
        /// <summary>
        ///  部分退款/全部退款
        /// </summary>
        public string OnRefund33 { get; set; }
        /// <summary>
        ///  审核操作人
        /// </summary>
        public string OnRefund34 { get; set; }
        /// <summary>
        ///  举证超时
        /// </summary>
        public string OnRefund35 { get; set; }
        /// <summary>
        ///  是否零秒响应
        /// </summary>
        public string OnRefund36 { get; set; }
        /// <summary>
        ///  退款操作人
        /// </summary>
        public string OnRefund37 { get; set; }
        /// <summary>
        ///  退款原因标签
        /// </summary>
        public string OnRefund38 { get; set; }
        /// <summary>
        ///  
        /// </summary>
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatorUserId { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public bool? DeleteMark { get; set; }
        public DateTime? DeleteTime { get; set; }
        public string DeleteUserId { get; set; }
    }
}