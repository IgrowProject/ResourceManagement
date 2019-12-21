using IGrow.Entity.CommodityManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.CommodityManage
{
    public class ComondityDetailMap:EntityTypeConfiguration<ComondityDetailEntity>
    {
        public ComondityDetailMap()
        {
            this.ToTable("Igrow_CommondityDetail");
            this.HasKey(m=>m.IGrowID);
        }
    }
}
