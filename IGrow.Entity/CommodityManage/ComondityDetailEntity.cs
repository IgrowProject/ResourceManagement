using System;

namespace IGrow.Entity.CommodityManage
{
    /// <summary>
    /// 商品明细表
    /// </summary>
    public class ComondityDetailEntity : IEntity<ComondityDetailEntity>
    {
        /// <summary>
        /// 主键Id   ComondityDetailId
        /// </summary>
        public string IGrowID { get; set; } 

        ///// <summary>
        ///// 主商品ID
        ///// </summary>
        //public string CommodityInfoId { get; set; }

        /// <summary>
        /// 主商品ID(接口)
        /// </summary>
        public long ParentId { get; set; }

        ///// <summary>
        ///// 明细商品ID
        ///// </summary>
        //public long ID { get; set; }

        /// <summary>
        /// 商品明细创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 商品明细修改时间
        /// </summary>
        public DateTime ModifyDate { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public double Qty { get; set; }

        /// <summary>
        /// 权重比例
        /// </summary>
        public double Percent { get; set; }

        /// <summary>
        /// 明细商品的商品代码
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// 明细商品的商品名称
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SimpleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ItemSkuCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ItemSkuName { get; set; }

        /// <summary>
        /// 明细商品的标准售价
        /// </summary>
        public double SalesPrice { get; set; }
    }
}
