using IGrow.Entity.CommodityManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.CommodityManage
{
    public class ComonditySkuInfoMap:EntityTypeConfiguration<ComonditySkuInfoEntity>
    {
        public ComonditySkuInfoMap()
        {
            this.ToTable("Igrow_ComonditySkuInfo");
            this.HasKey(m=>m.IGrowID);
        }
    }
}
