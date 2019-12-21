using IGrow.Entity.TradeManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.TradeManage
{
    public class CommondityDetailMap : EntityTypeConfiguration<CommondityDetailEntity>
    { 
         public CommondityDetailMap()
        {
            this.ToTable("Igrow_GuanyiTradeDetail");
            this.HasKey(t => t.IGrowID);
        }
    }
}
 
