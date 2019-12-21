using System;
namespace IGrow.Entity.TradeManage
{
    public class GuanyiTradeDeliveryEntity : IEntity<GuanyiTradeDeliveryEntity>
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
        /// 发货状态
        /// </summary>
        public bool Delivery { get; set; }
        /// <summary>
        /// 发货单据号
        /// </summary>
        public string Code{ get; set; }
        /// <summary>
        /// 是否已打印物流单
        /// </summary>
        public bool PrintExpress { get; set; }
        /// <summary>
        /// 是否已打印发货单
        /// </summary>
        public bool PrintDeliveryList { get; set; }
        /// <summary>
        /// 是否已扫描
        /// </summary>
        public bool Scan{ get; set; }
        /// <summary>
        /// 是否已称重
        /// </summary>
        public bool Weight{ get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string Warehouse_name{ get; set; }
        /// <summary>
        /// 仓库代码
        /// </summary>
        public string Warehouse_code{ get; set; }
        /// <summary>
        /// 快递公司名称
        /// </summary>
        public string Express_name{ get; set; }
        /// <summary>
        /// 快递公司代码
        /// </summary>
        public string Express_code{ get; set; }
        /// <summary>
        /// 快递单号
        /// </summary>
        public string Mail_no{ get; set; } 
    }
}

