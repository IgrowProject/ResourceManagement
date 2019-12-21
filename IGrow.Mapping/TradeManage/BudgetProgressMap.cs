using IGrow.Entity.TradeManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.TradeManage
{
    public class BudgetProgressMap : EntityTypeConfiguration<BudgetProgressEntity>
    { 
         public BudgetProgressMap()
        {
            this.ToTable("Igrow_BudgetProgress");
            this.HasKey(t => t.IGrowID);
        }
    }
}
 
