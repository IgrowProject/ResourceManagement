using System;

namespace IGrow.Entity.TradeManage
{
    /// <summary>
    /// 预算目标
    /// </summary>
    public class BudgetTargetEntity : IEntity<BudgetTargetEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    { 
         public string IGrowID { get; set; }
        /// <summary>
        /// 月份
        /// </summary>
        public DateTime? Months { get; set; }
        /// <summary>
        /// 负责人
        /// </summary>
        public string Person { get; set; }
        /// <summary>
        /// 渠道
        /// </summary>
        public string GrossMargin { get; set; }
        /// <summary>
        /// 销售额
        /// </summary>
        public decimal RealSales { get; set; }
        /// <summary>
        /// 毛利率
        /// </summary>
        public decimal Extension { get; set; }
        /// <summary>
        /// 促销费用
        /// </summary>
        public decimal Incremental { get; set; }
        /// <summary>
        /// 活动费用
        /// </summary>
        public decimal Activity { get; set; }
        /// <summary>
        /// 平台扣点
        /// </summary>
        public decimal Point { get; set; }
        /// <summary>
        /// 运营资源
        /// </summary>
        public decimal Operational { get; set; }
        /// <summary>
        /// 补单资源
        /// </summary>
        public decimal Replenishment { get; set; }
        /// <summary>
        /// 销售费用
        /// </summary>
        public decimal SaleCost { get; set; }
        /// <summary>
        /// 利润率
        /// </summary>
        public decimal ProfitMargin { get; set; }
        /// <summary>
        /// 市场占有率
        /// </summary>
        public decimal MarketShare { get; set; }
        /// <summary>
        /// 渠道利润
        /// </summary>
        public string Description { get; set; }
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
