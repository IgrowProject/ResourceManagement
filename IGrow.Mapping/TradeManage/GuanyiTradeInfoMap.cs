using IGrow.Entity.TradeManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.TradeManage
{
    public class GuanyiTradeInfoMap : EntityTypeConfiguration<GuanyiTradeInfoEntity>
    { 
         public GuanyiTradeInfoMap()
        {
            this.ToTable("Igrow_GuanyiTradeInfo");
            this.HasKey(t => t.IGrowID);
        }
    }
}
 
