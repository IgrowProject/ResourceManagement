using System;

namespace IGrow.Entity.TradeManage
{
    /// <summary>
    /// 预算进度
    /// </summary>
    public class BudgetProgressEntity : IEntity<BudgetProgressEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    { 
         public string IGrowID { get; set; }
        /// <summary>
        /// 月份
        /// </summary>
        public DateTime? Months { get; set; }
        /// <summary>
        /// 目标销售额
        /// </summary>
        public decimal TargetSales { get; set; }
        /// <summary>
        /// 系统销售额
        /// </summary>
        public decimal SystemSales { get; set; }
        /// <summary>
        /// 真实销售额
        /// </summary>
        public decimal RealSales { get; set; }
        /// <summary>
        /// 应完成
        /// </summary>
        public decimal NeedCompleted { get; set; }
        /// <summary>
        /// 实际完成
        /// </summary>
        public decimal ActualCompletion { get; set; }
        /// <summary>
        /// 付费占比
        /// </summary>
        public decimal PayRatio { get; set; }
        /// <summary>
        /// 增量费用
        /// </summary>
        public decimal Increment { get; set; }
        /// <summary>
        /// 促销占比
        /// </summary>
        public decimal PromotionRatio { get; set; }
        /// <summary>
        /// 活动费用
        /// </summary>
        public decimal ActivityCost { get; set; }
        /// <summary>
        /// 总销售费用
        /// </summary>
        public decimal Total { get; set; }
        /// <summary>
        /// 实际毛利
        /// </summary>
        public decimal RealGross { get; set; }
        /// <summary>
        /// 利润率
        /// </summary>
        public decimal ProfitMargin { get; set; }
        /// <summary>
        /// 补单占比
        /// </summary>
        public decimal Supplement { get; set; }
        /// <summary>
        /// 市场占有率
        /// </summ
        public decimal MarketShare { get; set; }
        /// <summary>
        /// 020佣金
        /// </summary>
        public decimal Commission { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// 渠道利润
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CreatorUserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ModifyDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ModifyUserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? DeleteMark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? DeleteTime { get; set; }
        public string DeleteUserId { get; set; }
    }
}
