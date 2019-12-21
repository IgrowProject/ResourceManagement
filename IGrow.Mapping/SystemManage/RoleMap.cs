/*******************************************************************************
 * Copyright © 2019 .Framework 版权所有
 * Author: DaleCloud
 * Description: 快速开发平台
 * Website：
*********************************************************************************/
using IGrow.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace IGrow.Mapping.SystemManage
{
    public class RoleMap : EntityTypeConfiguration<RoleEntity>
    {
        public RoleMap()
        {
            this.ToTable("Sys_Role");
            this.HasKey(t => t.IGrowID);
        }
    }
}
