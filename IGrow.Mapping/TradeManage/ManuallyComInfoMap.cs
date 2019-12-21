using IGrow.Entity.TradeManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.TradeManage
{
    public class ManuallyComInfoMap : EntityTypeConfiguration<ManuallyComInfoEntity>
    {
        public ManuallyComInfoMap()
        {
            this.ToTable("Igrow_ManuallyComInfo");
            this.HasKey(t => t.IGrowID);
        }
    }
}
