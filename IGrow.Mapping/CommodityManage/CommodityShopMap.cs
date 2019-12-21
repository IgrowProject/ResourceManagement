using IGrow.Entity.CommodityManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.CommodityManage
{
    public class CommodityShopMap : EntityTypeConfiguration<CommodityShopEntity>
    {
        public CommodityShopMap()
        {
            this.ToTable("Igrow_CommodityShop");
            this.HasKey(t => t.IGrowID);
        }
    }
}
