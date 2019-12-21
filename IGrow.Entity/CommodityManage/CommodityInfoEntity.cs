using System; 

namespace IGrow.Entity.CommodityManage
{
    /// <summary>
    /// 商品信息基础表
    /// </summary>
    public class CommodityInfoEntity : IEntity<CommodityInfoEntity>
    {
        /// <summary>
        /// 主键ID  CommodityInfoId
        /// </summary>
        //public string IGrowID { get; set; }
        ///// <summary>
        ///// 商品ID
        ///// </summary>
        public long IGrowID { get; set; }
        /// <summary>
        /// 商品代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; }
        ///// <summary>
        ///// 商品明细创建时间
        ///// </summary>
        //public DateTime? IGrowID { get; set; }
        ///// <summary>
        ///// 商品明细修改时间
        ///// </summary>
        //public DateTime? ModifyDate { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// 重量
        /// </summary>
        public decimal Weight { get; set; }
        /// <summary>
        /// 是否为组合商品
        /// </summary>
        public bool Combine { get; set; }
        /// <summary>
        /// 是否已停用
        /// </summary>
        public bool Del { get; set; }
        /// <summary>
        /// 长
        /// </summary>
        public decimal Length { get; set; }
        /// <summary>
        /// 宽
        /// </summary>
        public decimal Width { get; set; }
        /// <summary>
        /// 高
        /// </summary>
        public decimal Height { get; set; }
        /// <summary>
        /// 体积
        /// </summary>
        public decimal Volume { get; set; }
        /// <summary>
        /// 商品简称
        /// </summary>
        public string SimpleName { get; set; }
        /// <summary>
        /// 分类代码
        /// </summary>
        public string CategoryCode { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// 供应商代码
        /// </summary>
        public string SupplierCode { get; set; }
        /// <summary>
        /// 商品单位代码
        /// </summary>
        public string ItemUnitCode { get; set; }
        /// <summary>
        /// 商品单位名称
        /// </summary>
        public string ItemUnitName { get; set; }
        /// <summary>
        /// 打包积分
        /// </summary>
        public decimal PackagePoint { get; set; }
        /// <summary>
        /// 销售积分
        /// </summary>
        public decimal SalesPoint { get; set; }
        /// <summary>
        /// 标准售价
        /// </summary>
        public decimal SalesPrice { get; set; }
        /// <summary>
        /// 标准进价
        /// </summary>
        public decimal PurchasePrice { get; set; }
        /// <summary>
        /// 代理售价
        /// </summary>
        public decimal AgentPrice { get; set; }
        /// <summary>
        /// 成本价
        /// </summary>
        public decimal CostPrice { get; set; }
        /// <summary>
        /// 库存状态代码
        /// </summary>
        public string StockStatusCode { get; set; }
        /// <summary>
        /// 图片地址
        /// </summary>
        public string PicUrl { get; set; }
        /// <summary>
        /// 税号
        /// </summary>
        public string TaxNo { get; set; }
        /// <summary>
        /// 税率
        /// </summary>
        public decimal TaxRate { get; set; }
        /// <summary>
        /// 原产地
        /// </summary>
        public string OriginArea { get; set; }
        /// <summary>
        /// 供应商货号
        /// </summary>
        public string SupplierOuterid { get; set; }
        /// <summary>
        /// 保质期
        /// </summary>
        public int ShelfLife { get; set; }
        /// <summary>
        /// 预警天数
        /// </summary>
        public int WarningDays { get; set; }

        /// <summary>
        /// 规格信息
        /// </summary>
        //public object[] Skus { get; set; }
        /// <summary>
        /// 组合明细
        /// </summary>
        //public object[] CombineItems { get; set; }
        /// <summary>
        /// 自定义属性
        /// </summary>
        //public Custom_Attr CustomAttr { get; set; }

        /// <summary>
        /// 商品附加属性 
        /// 0:普通商品
        ///1:唯一码商品
        ///2:批次商品
        /// </summary>
        public int ItemAddAttribute { get; set; }
        /// <summary>
        /// 品牌ID
        /// </summary>
        public string ItemBrandId { get; set; }
        /// <summary>
        /// 品牌代码
        /// </summary>
        public string ItemBrandCode { get; set; }
        /// <summary>
        /// 品牌名称
        /// </summary>
        public string ItemBrandName { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //public long goods_id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatorUserId { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public bool? DeleteMark { get; set; }     
        public DateTime? DeleteTime { get; set; }
        public string DeleteUserId { get; set; }
    }
}
