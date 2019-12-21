using IGrow.Entity.CommodityManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.CommodityManage
{
    public class CommodityInfoMap : EntityTypeConfiguration<CommodityInfoEntity>
    {
        public CommodityInfoMap()
        {
            this.ToTable("Igrow_CommodityInfo");
            this.HasKey(t => t.IGrowID);
        }
    }
}
