using System; 

namespace IGrow.Entity.CommodityManage
{
   public class ComondityPlatformEntity : IEntity<ComondityPlatformEntity>
    {
        /// <summary>
        /// 主键ComondityPlatformId
        /// </summary>
        public string IGrowID { get; set; }
        /// <summary>
        /// 店铺ID
        /// </summary>
        public long ShopID { get; set; }
        /// <summary>
        /// 商家编码
        /// </summary>
        public string ShopCode { get; set; }
        /// <summary>
        /// 店铺
        /// </summary>
        public string ShopName { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        public long SpuID { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string SpuName { get; set; }
        /// <summary>
        /// 平台规格Id
        /// </summary>
        public long SkuId { get; set; }
        /// <summary>
        /// 规格商品编码
        /// </summary>
        public string SkuCode { get; set; }
        /// <summary>
        /// 规格名称
        /// </summary>
        public string SkuName { get; set; }
        /// <summary>
        /// 系统商品代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 系统商品名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 系统规格代码
        /// </summary>
        public string Sku { get; set; }
        /// <summary>
        /// 系统规格名称
        /// </summary>
        public string CName { get; set; }

        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 商品明细修改时间
        /// </summary>
        public DateTime? ModifyDate { get; set; }


    }
}
