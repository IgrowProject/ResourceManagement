using IGrow.Entity.TradeManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.TradeManage
{
    public class GuanyiTradePaymentMap : EntityTypeConfiguration<GuanyiTradePaymentEntity>
    { 
         public GuanyiTradePaymentMap()
        {
            this.ToTable("Igrow_GuanyiTradePayment");
            this.HasKey(t => t.IGrowID);
        }
    }
}
 
