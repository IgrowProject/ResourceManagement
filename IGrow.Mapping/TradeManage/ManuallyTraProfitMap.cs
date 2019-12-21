using IGrow.Entity.TradeManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.TradeManage
{
    public class ManuallyTraProfitMap : EntityTypeConfiguration<ManuallyTraProfitEntity>
    {
        public ManuallyTraProfitMap()
        {
            this.ToTable("Igrow_ManuallyTraProfit");
            this.HasKey(t => t.IGrowID);
        }
    }
}
