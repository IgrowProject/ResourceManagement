using System;
namespace IGrow.Entity.TradeManage
{
    public class GuanyiTradePaymentEntity : IEntity<GuanyiTradePaymentEntity>
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public string IGrowID { get; set; }
        /// <summary>
        ///  子订单号
        /// </summary> 
        public string Oid { get; set; }
        /// <summary>
        ///  支付金额
        /// </summary> 
        public double Payment { get; set; }
        /// <summary>
        ///  支付交易号
        /// </summary> 
        public string PayCode { get; set; }
        /// <summary>
        /// 支付方式名称
        /// </summary>
        public string Pay_type_name { get; set; }
        /// <summary>
        ///  支付时间
        /// </summary> 
        public DateTime? Paytime { get; set; }
    }
}
