﻿/*******************************************************************************
 * Copyright © 2019 .Framework 版权所有
 * Author: DaleCloud
 * Description: 快速开发平台
 * Website：
*********************************************************************************/
using IGrow.Code;
using IGrow.Entity.SystemManage;
using IGrow.Domain.IRepository.SystemManage;
using IGrow.Repository.SystemManage;

namespace IGrow.Application.SystemManage
{
    public class UserLogOnApp
    {
        private IUserLogOnRepository service = new UserLogOnRepository();

        public UserLogOnEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void UpdateForm(UserLogOnEntity userLogOnEntity)
        {
            service.Update(userLogOnEntity);
        }
        public void RevisePassword(string userPassword,string keyValue)
        {
            UserLogOnEntity userLogOnEntity = new UserLogOnEntity();
            userLogOnEntity = service.FindEntity(keyValue);
            if (userLogOnEntity == null)
            {
                userLogOnEntity = new UserLogOnEntity();
                userLogOnEntity.IGrowID = keyValue;
                userLogOnEntity.F_UserId = keyValue;
                userLogOnEntity.F_UserSecretkey = Md5.md5(CommonUtils.CreateNo(), 16).ToLower();
                userLogOnEntity.F_UserPassword = Md5.md5(DESEncrypt.Encrypt(Md5.md5(userPassword, 32).ToLower(), userLogOnEntity.F_UserSecretkey).ToLower(), 32).ToLower();
                service.Insert(userLogOnEntity);
            }
            else
            {
                userLogOnEntity = new UserLogOnEntity();
                userLogOnEntity.IGrowID = keyValue;
                userLogOnEntity.F_UserSecretkey = Md5.md5(CommonUtils.CreateNo(), 16).ToLower();
                userLogOnEntity.F_UserPassword = Md5.md5(DESEncrypt.Encrypt(Md5.md5(userPassword, 32).ToLower(), userLogOnEntity.F_UserSecretkey).ToLower(), 32).ToLower();
                service.Update(userLogOnEntity);
            }
           
        }
    }
}
