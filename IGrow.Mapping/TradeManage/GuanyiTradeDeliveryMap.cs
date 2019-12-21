using IGrow.Entity.TradeManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.TradeManage
{
    public class GuanyiTradeDeliveryMap : EntityTypeConfiguration<GuanyiTradeDeliveryEntity>
    { 
         public GuanyiTradeDeliveryMap()
        {
            this.ToTable("Igrow_GuanyiTradeDelivery");
            this.HasKey(t => t.IGrowID);
        }
    }
}
 
