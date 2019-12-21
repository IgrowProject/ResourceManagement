using System;

namespace IGrow.Entity.TradeManage
{

    /// <summary>
    /// 商品订单表-人工导入
    /// </summary>
    public class ManuallyComInfoEntity : IEntity<ManuallyComInfoEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
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
        /// 标题
        /// </summary>
        public string SpuName { get; set; } 
        /// 数量
        /// </summary>
        public int Amount { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 外部系统编号
        /// </summary>
        public string SkuCode { get; set; }
        /// <summary>
        /// 商品属性
        /// </summary>
        public string SkuName { get; set; }
        /// <summary>
        /// 套餐信息
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        ///
        ///  商家编码
        /// 
        public string Code { get; set; }
        /// <summary>
        ///  订单状态
        /// </summary>
        public string DState { get; set; } 
        public DateTime? CreateDate { get; set; }
        public string CreatorUserId { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public bool? DeleteMark { get; set; }
        public DateTime? DeleteTime { get; set; }
        public string DeleteUserId { get; set; }
    }
}
