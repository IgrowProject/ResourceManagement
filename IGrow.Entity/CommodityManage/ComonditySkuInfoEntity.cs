using System;

namespace IGrow.Entity.CommodityManage
{
    /// <summary>
    /// 商品规格信息基础表
    /// </summary>
    public class ComonditySkuInfoEntity : IEntity<ComonditySkuInfoEntity>
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        //public string ComonditySkuInfoId { get; set; }
        public string IGrowID { get; set; }
        /// <summary>
        /// 主商品ID
        /// </summary>
        public string CommodityInfoId { get; set; }

        /// <summary>
        /// 主商品ID(接口)
        /// </summary>
        public long ParentId { get; set; }

        /// <summary>
        /// 规格ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 规格代码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 规格名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// 体积
        /// </summary>
        public double Volume { get; set; }

        /// <summary>
        /// 打包积分
        /// </summary>
        public double PackagePoint { get; set; }

        /// <summary>
        /// 销售积分
        /// </summary>
        public double SalesPoint { get; set; }

        /// <summary>
        /// 标准售价
        /// </summary>
        public double SalesPrice { get; set; }

        /// <summary>
        /// 标准进价
        /// </summary>
        public double PurchasePrice { get; set; }

        /// <summary>
        /// 代理售价
        /// </summary>
        public double AgentPrice { get; set; }

        /// <summary>
        /// 成本价
        /// </summary>
        public double CostPrice { get; set; }

        /// <summary>
        /// 库存状态代码
        /// </summary>
        public string StockStatusCode { get; set; }

        /// <summary>
        /// 商品条码
        /// </summary>
        public string BarCode { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        public string TaxNo { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        public double TaxRate { get; set; }

        /// <summary>
        /// 原产地
        /// </summary>
        public string OriginArea { get; set; }

        /// <summary>
        /// 供应商货号
        /// </summary>
        public string SupplierOuterid { get; set; }

    }
}
