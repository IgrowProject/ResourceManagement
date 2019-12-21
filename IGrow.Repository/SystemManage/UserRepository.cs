/*******************************************************************************
 * Copyright © 2019 .Framework 版权所有
 * Author: DaleCloud
 * Description: 快速开发平台
 * Website：
*********************************************************************************/
using IGrow.Code;
using IGrow.DataBase;
using IGrow.Entity.SystemManage;
using IGrow.Domain.IRepository.SystemManage;
using IGrow.Repository.SystemManage;

namespace IGrow.Repository.SystemManage
{
    public class UserRepository : RepositoryBase<UserEntity>, IUserRepository
    {
        public void DeleteForm(string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                db.Delete<UserEntity>(t => t.IGrowID == keyValue);
                db.Delete<UserLogOnEntity>(t => t.F_UserId == keyValue);
                db.Commit();
            }
        }
        public void SubmitForm(UserEntity userEntity, UserLogOnEntity userLogOnEntity, string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                if (!string.IsNullOrEmpty(keyValue))
                {
                    db.Update(userEntity);
                }
                else
                {
                    userLogOnEntity.IGrowID = userEntity.IGrowID;
                    userLogOnEntity.F_UserId = userEntity.IGrowID;
                    userLogOnEntity.F_UserSecretkey = Md5.md5(CommonUtils.CreateNo(), 16).ToLower();
                    userLogOnEntity.F_UserPassword = Md5.md5(DESEncrypt.Encrypt(Md5.md5(userLogOnEntity.F_UserPassword, 32).ToLower(), userLogOnEntity.F_UserSecretkey).ToLower(), 32).ToLower();
                    db.Insert(userEntity);
                    db.Insert(userLogOnEntity);
                }
                db.Commit();
            }
        }
    }
}
