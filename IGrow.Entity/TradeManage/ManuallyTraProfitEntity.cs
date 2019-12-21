using System;

namespace IGrow.Entity.TradeManage
{
    /// <summary>
    /// 毛利
    /// </summary>
    public class ManuallyTraProfitEntity : IEntity<ManuallyTraProfitEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public string IGrowID { get; set; }
        /// <summary>
        /// 商品
        /// </summary>
        public string Platform_code { get; set; }
        /// <summary>
        /// sku收入
        /// </summary>
        public string SpuName { get; set; }
        /// <summary>
        /// sku成本
        /// </summary>
        public long SkuID { get; set; }
        /// <summary>
        /// sku毛利率
        /// </summary>
        public string Income { get; set; }
        /// <summary>
        /// spu收入
        /// </summary>
        public string Cost { get; set; }
        /// <summary>
        /// spu成本
        /// </summary>
        public string Refund { get; set; }
        /// <summary>
        /// spu毛利率
        /// </summary>
        public string Gross { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatorUserId { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public bool? DeleteMark { get; set; }
        public DateTime? DeleteTime { get; set; }
        public string DeleteUserId { get; set; }
    }
}
