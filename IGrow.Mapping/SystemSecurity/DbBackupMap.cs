/*******************************************************************************
 * Copyright © 2016 DaleCloud.Framework 版权所有
 * Author: DaleCloud
 * Description: 快速开发平台
 * Website：
*********************************************************************************/
using IGrow.Entity.SystemSecurity;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.SystemSecurity
{
    public class DbBackupMap : EntityTypeConfiguration<DbBackupEntity>
    {
        public DbBackupMap()
        {
            this.ToTable("Sys_DbBackup");
            this.HasKey(t => t.IGrowID);
        }
    }
}
