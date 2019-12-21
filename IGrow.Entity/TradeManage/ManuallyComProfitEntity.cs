using System;

namespace IGrow.Entity.TradeManage
{
    /// <summary>
    /// 毛利
    /// </summary>
    public class ManuallyComProfitEntity : IEntity<ManuallyComProfitEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public string IGrowID { get; set; }
        /// <summary>
        /// 商品
        /// </summary>
        public long SpuID { get; set; }
        /// <summary>
        /// sku收入
        /// </summary>
        public string SpuCode { get; set; }
        /// <summary>
        /// sku成本
        /// </summary>
        public string SpuName { get; set; }
        /// <summary>
        /// sku毛利率
        /// </summary>
        public decimal Cost { get; set; }
        /// <summary>
        /// spu收入
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// spu成本
        /// </summary>
        public int SkuCount { get; set; }
        /// <summary>
        /// spu毛利率
        /// </summary>
        public decimal SkuDealPrice { get; set; }
        /// <summary>
        /// 渠道收入
        /// </summary>
        public decimal SpuDealPrice { get; set; }
        /// <summary>
        /// 渠道成本
        /// </summary>
        public decimal SkuSpuRatio { get; set; }
        /// <summary>
        /// 渠道毛利率
        /// </summary>
        public decimal SkuSumRatio { get; set; }
        public decimal SkuCountRatio { get; set; }
        public decimal SpuDealRatio { get; set; }
        public decimal Gross { get; set; }
        public decimal SkuGross { get; set; }
        public decimal SpuGross { get; set; }
        public decimal GrossSum { get; set; } 
        public DateTime? CreateDate { get; set; }
        public string CreatorUserId { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public bool? DeleteMark { get; set; }
        public DateTime? DeleteTime { get; set; }
        public string DeleteUserId { get; set; }
    }
}
