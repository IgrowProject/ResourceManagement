using System;

namespace IGrow.Entity.TradeManage
{ 
    /// <summary>
    /// 日-店铺数据
    /// </summary>
    public class DailyEntity : IEntity<DailyEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
         /// <summary>
         /// 
         /// </summary>
         public string IGrowID { get; set; }
        /// <summary>
        /// 活动节奏
        /// </summary>
        public string F_Activity { get; set; }
        /// <summary>
        /// 销售额
        /// </summary>
        public string OnDaily01 { get; set; }
        /// <summary>
        /// 市场占有率
        /// </summary>
        public string OnDaily02 { get; set; }
        /// <summary>
        /// 店铺学习桌销售额
        /// </summary>
        public string OnDaily03 { get; set; }
        /// <summary>
        /// 学习桌行业
        /// </summary>
        public string OnDaily04 { get; set; }
        /// <summary>
        /// 营业额
        /// </summary>
        public string OnDaily05 { get; set; }
        /// <summary>
        /// 活动费用
        /// </summary>
        public string OnDaily06 { get; set; }
        /// <summary>
        /// 真实营业额
        /// </summary>
        public string OnDaily07 { get; set; }
        /// <summary>
        /// 补单金额
        /// </summary>
        public string OnDaily08 { get; set; }
        /// <summary>
        /// 差价
        /// </summary>
        public string OnDaily09 { get; set; }
        /// <summary>
        /// O2O销售额
        /// </summary>
        public string OnDaily10 { get; set; }
        /// <summary>
        /// 退款金额
        /// </summary>
        public string OnDaily11 { get; set; }
        /// <summary>
        /// 客单价
        /// </summary>
        public string OnDaily12 { get; set; }
        /// <summary>
        /// 访客数
        /// </summary>
        public string OnDaily13 { get; set; }
        /// <summary>
        /// 搜索
        /// </summary>
        public string OnDaily14 { get; set; }
        /// <summary>
        /// 直钻超汇总
        /// </summary>
        public string OnDaily15 { get; set; }
        /// <summary>
        /// 直通车
        /// </summary>
        public string OnDaily16 { get; set; }
        /// <summary>
        /// 钻展
        /// </summary>
        public string OnDaily17 { get; set; }
        /// <summary>
        /// 超级推荐
        /// </summary>
        public string OnDaily18 { get; set; }
        /// <summary>
        /// 聚划算
        /// </summary>
        public string OnDaily19 { get; set; }
        /// <summary>
        /// 转化率
        /// </summary>
        public string OnDaily20 { get; set; }
        /// <summary>
        /// 买家数
        /// </summary>
        public string OnDaily21 { get; set; }
        /// <summary>
        /// 套装
        /// </summary>
        public string OnDaily22 { get; set; }
        /// <summary>
        /// 学习桌
        /// </summary>
        public string OnDaily23 { get; set; }
        /// <summary>
        /// 刷单数
        /// </summary>
        public string OnDaily24 { get; set; }
        /// <summary>
        /// 付费金额
        /// </summary>
        public string OnDaily25 { get; set; }
        /// <summary>
        /// 付费金额占比
        /// </summary>
        public string OnDaily26 { get; set; }
        /// <summary>
        /// PPC
        /// </summary>
        public string OnDaily27 { get; set; }
        /// <summary>
        /// 询单率
        /// </summary>
        public string OnDaily28 { get; set; }
        /// <summary>
        /// 询单人数
        /// </summary>
        public string OnDaily29 { get; set; }
        /// <summary>
        /// 支付买家数
        /// </summary>
        public string OnDaily30 { get; set; }
        /// <summary>
        /// 询单转化率
        /// </summary>
        public string OnDaily31 { get; set; }
        /// <summary>
        /// 流失金额
        /// </summary>
        public string OnDaily32 { get; set; }
        /// <summary>
        /// 流失率
        /// </summary>
        public string OnDaily33 { get; set; }
        /// <summary>
        /// 加购人数
        /// </summary>
        public string OnDaily34 { get; set; }
        /// <summary>
        /// 加购率
        /// </summary>
        public string OnDaily35 { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatorUserId { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public bool? DeleteMark { get; set; }
        public DateTime? DeleteTime { get; set; }
        public string DeleteUserId { get; set; }
    }
}
