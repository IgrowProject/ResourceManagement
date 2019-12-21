using IGrow.Entity.TradeManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.TradeManage
{
    public class BudgetTargetMap : EntityTypeConfiguration<BudgetTargetEntity>
    { 
         public BudgetTargetMap()
        {
            this.ToTable("Igrow_BudgetTarget");
            this.HasKey(t => t.IGrowID);
        }
    }
}
 
