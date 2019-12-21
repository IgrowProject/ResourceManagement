using System;
namespace IGrow.Entity.TradeManage
{
    public class GuanyiTradeInvoiceEntity : IEntity<GuanyiTradeInvoiceEntity>
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public string IGrowID { get; set; }
        /// <summary>
        /// 子订单号
        /// </summary>
        public string Oid { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address{ get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone{ get; set; }
        /// <summary>
        /// 发票种类名称 增值普通发票or增值专用发票
        /// </summary>
        public string Invoice_type_name{ get; set; }
        /// <summary>
        /// 发票抬头
        /// </summary>
        public string Invoice_title{ get; set; }
        /// <summary>
        /// 发票内容
        /// </summary>
        public string Invoice_content{ get; set; }
        /// <summary>
        /// 发票金额
        /// </summary>
        public string Invoice_amount{ get; set; }
        /// <summary>
        /// 纳税人识别号
        /// </summary>
        public string Tex_payer_number{ get; set; }
        /// <summary>
        /// 开户行
        /// </summary>
        public string Bank_name{ get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string Bank_account{ get; set; }
        /// <summary>
        /// 发票类型 1:纸质发票2:电子发票
        /// </summary>
        public int Invoice_type{ get; set; }
    }
}

