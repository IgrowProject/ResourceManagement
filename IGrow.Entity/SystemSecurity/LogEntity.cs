/*******************************************************************************
 * Copyright © 2016 DaleCloud.Framework 版权所有
 * Author: DaleCloud
 * Description: 快速开发平台
 * Website：
*********************************************************************************/
using System;

namespace IGrow.Entity.SystemSecurity
{
    public class LogEntity : IEntity<LogEntity>, ICreationAudited
    {
        public string IGrowID { get; set; }
        public DateTime? F_Date { get; set; }
        public string F_Account { get; set; }
        public string F_NickName { get; set; }
        public string F_Type { get; set; }
        public string F_IPAddress { get; set; }
        public string F_IPAddressName { get; set; }
        public string F_ModuleId { get; set; }
        public string F_ModuleName { get; set; }
        public bool? F_Result { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatorUserId { get; set; }
    }
}
