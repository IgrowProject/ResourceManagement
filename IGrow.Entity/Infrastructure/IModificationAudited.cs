/*******************************************************************************
 * Copyright © 2016 DaleCloud.Framework 版权所有
 * Author: DaleCloud
 * Description: 快速开发平台
 * Website：
*********************************************************************************/
using System;

namespace IGrow.Entity
{
    public interface IModificationAudited
    {
        string IGrowID { get; set; }
        string ModifyUserId { get; set; }
        DateTime? ModifyDate { get; set; }
    }
}