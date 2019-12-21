using IGrow.Entity.TradeManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.TradeManage
{
    public class ManuallyComProfitMap : EntityTypeConfiguration<ManuallyComProfitEntity>
    {
        public ManuallyComProfitMap()
        {
            this.ToTable("Igrow_ManuallyComProfit");
            this.HasKey(t => t.IGrowID);
        }
    }
}
