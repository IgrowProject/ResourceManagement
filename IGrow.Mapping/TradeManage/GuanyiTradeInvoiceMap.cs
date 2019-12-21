using IGrow.Entity.TradeManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.TradeManage
{
    public class GuanyiTradeInvoiceMap : EntityTypeConfiguration<GuanyiTradeInvoiceEntity>
    { 
         public GuanyiTradeInvoiceMap()
        {
            this.ToTable("Igrow_GuanyiTradeInvoice");
            this.HasKey(t => t.IGrowID);
        }
    }
}
 
