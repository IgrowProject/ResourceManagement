/*******************************************************************************
 * Copyright © 2016 DaleCloud.Framework 版权所有
 * Author: DaleCloud
 * Description: 快速开发平台
 * Website：
*********************************************************************************/
using IGrow.Code;
using System;

namespace IGrow.Entity
{
    public class IEntity<TEntity>
    {
        public void Create()
        {
            var entity = this as ICreationAudited;
            entity.IGrowID = CommonUtils.GuId();
            var LoginInfo = OperatorProvider.Provider.GetCurrent();
            if (LoginInfo != null)
            {
                entity.CreatorUserId = LoginInfo.UserId;
            }
            entity.CreateDate = DateTime.Now;
        }
        public void Modify(string keyValue)
        {
            var entity = this as IModificationAudited;
            entity.IGrowID = keyValue;
            var LoginInfo = OperatorProvider.Provider.GetCurrent();
            if (LoginInfo != null)
            {
                entity.ModifyUserId = LoginInfo.UserId;
            }
            entity.ModifyDate = DateTime.Now;
        }
        public void Remove()
        {
            var entity = this as IDeleteAudited;
            var LoginInfo = OperatorProvider.Provider.GetCurrent();
            if (LoginInfo != null)
            {
                entity.DeleteUserId = LoginInfo.UserId;
            }
            entity.DeleteTime = DateTime.Now;
            entity.DeleteMark = true;
        }
    }
}
