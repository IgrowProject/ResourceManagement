using IGrow.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.SystemManage 
{
    public class AreaMap : EntityTypeConfiguration<AreaEntity>
    {
        public AreaMap()
        {
            this.ToTable("Sys_Area");
            this.HasKey(t => t.IGrowID);
        }
    }
}
