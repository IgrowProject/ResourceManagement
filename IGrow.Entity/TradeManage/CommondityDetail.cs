using System;
namespace IGrow.Entity.TradeManage
{
    public class CommondityDetailEntity : IEntity<CommondityDetailEntity>
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        // public string ItemID { get; set; }
        public string IGrowID { get; set; }

        public string ParentID { get; set; }
        /// <summary>
        /// 子订单号
        /// </summary>
        public string Oid { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public double Qty{ get; set; }
        /// <summary>
        /// 实际单价
        /// </summary>
        public double Price{ get; set; }
        /// <summary>
        /// 实际金额
        /// </summary>
        public double Amount { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Note{ get; set; }
        /// <summary>
        /// 商品代码
        /// </summary>
        public string Item_code{ get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Item_name{ get; set; }
        /// <summary>
        /// 商品简称
        /// </summary>
        public string Item_simple_name{ get; set; }
        /// <summary>
        /// 规格名称
        /// </summary>
        public string Sku_name{ get; set; }
        /// <summary>
        /// 规格代码
        /// </summary>
        public string Sku_code{ get; set; }
        /// <summary>
        /// 物流费用
        /// </summary>
        public double Post_fee { get; set; }
        /// <summary>
        /// 让利金额
        /// </summary>
        public double Discount_fee { get; set; }
        /// <summary>
        /// 让利后金额
        /// </summary>
        public double Amount_after { get; set; }
        /// <summary>
        /// 退款状态 0:未退款1:退款成功2:退款中
        /// </summary>
        public int Refund{ get; set; }
        /// <summary>
        /// 平台规格名称
        /// </summary>
        public string Platform_item_name{ get; set; }
        /// <summary>
        /// 平台规格代码
        /// </summary>
        public string Platform_sku_name{ get; set; }
        /// <summary>
        /// 商品备注
        /// </summary>
        public string Sku_note{ get; set; }
    }
}
