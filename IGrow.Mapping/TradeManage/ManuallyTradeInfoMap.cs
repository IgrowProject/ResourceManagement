using IGrow.Entity.TradeManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.TradeManage
{
    public class ManuallyTradeInfoMap : EntityTypeConfiguration<ManuallyTradeInfoEntity>
    {
        public ManuallyTradeInfoMap()
        {
            this.ToTable("Igrow_ManuallyTradeInfo");
            this.HasKey(t => t.IGrowID);
        }
    }
}
