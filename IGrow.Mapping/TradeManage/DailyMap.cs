using IGrow.Entity.TradeManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.TradeManage
{
    public class DailyMap : EntityTypeConfiguration<DailyEntity>
    {
        public DailyMap()
        {
            this.ToTable("Igrow_ManuallyDaily");
            this.HasKey(t => t.IGrowID);
        }
    }
}
