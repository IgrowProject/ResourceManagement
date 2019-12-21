/*******************************************************************************
 * Copyright © 2016 DaleCloud.Framework 版权所有
 * Author: DaleCloud
 * Description: 快速开发平台
 * Website：
*********************************************************************************/
using System;

namespace IGrow.Entity
{
    public interface ICreationAudited
    {
        string IGrowID { get; set; }
        string CreatorUserId { get; set; }
        DateTime? CreateDate { get; set; }
    }
}