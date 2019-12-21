using System;

namespace IGrow.Entity.CommodityManage
{
    public class CommodityShopEntity : IEntity<CommodityShopEntity>
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public string IGrowID { get; set; }
        /// <summary>
        /// 管易店铺ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 店铺昵称
        /// </summary>
        public string Nick { get; set; }
        /// <summary>
        /// 代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string Type_name { get; set; }
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 商品明细修改时间
        /// </summary>
        public DateTime ModifyDate { get; set; }
    }
}
