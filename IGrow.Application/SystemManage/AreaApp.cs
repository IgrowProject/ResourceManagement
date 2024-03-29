﻿using IGrow.Entity.SystemManage;
using IGrow.Domain.IRepository.SystemManage;
using IGrow.Repository.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IGrow.Application.SystemManage
{
    public class AreaApp
    {
        private IAreaRepository service = new AreaRepository();

        public List<AreaEntity> GetList()
        {
            return service.IQueryable().ToList();
        }
        public AreaEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(string keyValue)
        {
            if (service.IQueryable().Count(t => t.F_ParentId.Equals(keyValue)) > 0)
            {
                throw new Exception("删除失败！操作的对象包含了下级数据。");
            }
            else
            {
                service.Delete(t => t.IGrowID == keyValue);
            }
        }
        public void SubmitForm(AreaEntity mEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                mEntity.Modify(keyValue);
                service.Update(mEntity);
            }
            else
            {
                mEntity.Create();
                service.Insert(mEntity);
            }
        }
    }
}
