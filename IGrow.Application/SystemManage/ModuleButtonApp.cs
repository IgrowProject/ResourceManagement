/*******************************************************************************
 * Copyright © 2019 .Framework 版权所有
 * Author: DaleCloud
 * Description: 快速开发平台
 * Website：
*********************************************************************************/
using IGrow.Code;
using IGrow.Entity.SystemManage;
using IGrow.Domain.IRepository.SystemManage;
using IGrow.Repository.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IGrow.Application.SystemManage
{
    public class ModuleButtonApp
    {
        private IModuleButtonRepository service = new ModuleButtonRepository();

        public List<ModuleButtonEntity> GetList(string moduleId = "")
        {
            var expression = ExtLinq.True<ModuleButtonEntity>();
            if (!string.IsNullOrEmpty(moduleId))
            {
                expression = expression.And(t => t.F_ModuleId == moduleId);
            }
            return service.IQueryable(expression).OrderBy(t => t.F_SortCode).ToList();
        }
        public ModuleButtonEntity GetForm(string keyValue)
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
        public void SubmitForm(ModuleButtonEntity moduleButtonEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                moduleButtonEntity.Modify(keyValue);
                service.Update(moduleButtonEntity);
            }
            else
            {
                moduleButtonEntity.Create();
                service.Insert(moduleButtonEntity);
            }
        }
        public void SubmitCloneButton(string moduleId, string Ids)
        {
            string[] ArrayId = Ids.Split(',');
            var data = this.GetList();
            List<ModuleButtonEntity> entitys = new List<ModuleButtonEntity>();
            foreach (string item in ArrayId)
            {
                ModuleButtonEntity moduleButtonEntity = data.Find(t => t.IGrowID == item);
                moduleButtonEntity.IGrowID = CommonUtils.GuId();
                moduleButtonEntity.F_ModuleId = moduleId;
                entitys.Add(moduleButtonEntity);
            }
            service.SubmitCloneButton(entitys);
        }
    }
}
