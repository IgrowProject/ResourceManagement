using System;

namespace IGrow.Entity.TradeManage
{

    /// <summary>
    /// 商品订单表-人工导入
    /// </summary>
    public class ManuallyTraComInfoEntity : IEntity<ManuallyTraComInfoEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        /// <summary>
        /// 
        /// </summary>
        public string IGrowID { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string Platform_code { get; set; }
        /// <summary>
        /// 拍下时间
        /// </summary>
        public DateTime? Dealtime { get; set; }
        /// <summary>
        /// 付款时间
        /// </summary>
        public DateTime? Paytime { get; set; }
        /// <summary>
        /// 发货时间
        /// </summary>
        public DateTime? DeliveryTime { get; set; }
        /// <summary>
        /// 交易结束时间
        /// </summary>
        public DateTime? Endtime { get; set; }
        /// <summary>
        /// 商家编码
        /// </summary>
        public string ShopCode { get; set; }
        /// <summary>
        /// 宝贝名称
        /// </summary>
        public string SpuID { get; set; }
        /// <summary>
        /// 商品数字ID
        /// </summary>
        public string SpuName { get; set; }
        /// <summary>
        /// 属性
        /// </summary>
        public string SpuMemo { get; set; }
        /// <summary>
        /// 属性商家编码
        /// </summary>
        public string SkuCode { get; set; }
        /// <summary>
        /// SKUID
        /// </summary>
        public string SkuId { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Amount { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 实际单价
        /// </summary>
        public decimal SPrice { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal JPrice { get; set; }
        /// <summary>
        /// 子订单状态
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// 退款状态
        /// </summary>
        public DateTime? TState { get; set; }
        /// <summary>
        /// 总价
        /// </summary>
        public decimal SumPrice { get; set; }
        /// <summary>
        /// 买家留言
        /// </summary>
        public string SellNote { get; set; }
        /// <summary>
        /// 卖家备注
        /// </summary>
        public string SellRemarks { get; set; }
        /// <summary>
        /// 卖家备注旗帜
        /// </summary>
        public string SellFlag { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public string DState { get; set; }
        /// <summary>
        /// 买家昵称
        /// </summary>
        public string BuyerName { get; set; }
        /// <summary>
        /// 收件人信息
        /// </summary>
        public string AddInfor { get; set; }
        /// <summary>
        /// 分阶段付款订单状态
        /// </summary>
        public string FjdState { get; set; }
        /// <summary>
        /// 分阶段付款已付金额
        /// </summary>
        public decimal FjdPrice { get; set; }
         
        public DateTime? CreateDate { get; set; }
        public string CreatorUserId { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public bool? DeleteMark { get; set; }
        public DateTime? DeleteTime { get; set; }
        public string DeleteUserId { get; set; }
    }
}
