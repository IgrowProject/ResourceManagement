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
    public class ItemsMap : EntityTypeConfiguration<ItemsEntity>
    {
        public ItemsMap()
        {
            this.ToTable("Sys_Items");
            this.HasKey(t => t.IGrowID);
        }
    }
}
