using IGrow.Entity.TradeManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.TradeManage
{
    public class RefundMap : EntityTypeConfiguration<RefundEntity>
    {
        public RefundMap()
        {
            this.ToTable("Igrow_ManuallyRefund");
            this.HasKey(t => t.IGrowID);
        }
    }
}
