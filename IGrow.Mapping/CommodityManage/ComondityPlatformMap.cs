using IGrow.Entity.CommodityManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.CommodityManage
{
    public class ComondityPlatformMap : EntityTypeConfiguration<ComondityPlatformEntity>
    {
        public ComondityPlatformMap()
        {
            this.ToTable("Igrow_ComondityPlatform");
            this.HasKey(t => t.IGrowID);
        }
    }
}
