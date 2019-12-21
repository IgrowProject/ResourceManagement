using IGrow.Entity.SystemManage;
using IGrow.Domain.IRepository.SystemManage;
using IGrow.Repository.SystemManage;
using System;
using System.Linq;
using System.Collections.Generic;

using IGrow.Code;

namespace IGrow.Application.SystemManage
{
    public class ItemsApp
    {
        private IItemsRepository service = new ItemsRepository();

        public List<ItemsEntity> GetList()
        {
            return service.IQueryable().ToList();
        }
        public ItemsEntity GetForm(string keyValue)
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
        public void SubmitForm(ItemsEntity itemsEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                itemsEntity.Modify(keyValue);
                service.Update(itemsEntity);
            }
            else
            {
                itemsEntity.Create();
                service.Insert(itemsEntity);
            }
        }


        public string GetModelId(string keyValue)
        {
            var expression = ExtLinq.True<ItemsEntity>();
            if (!string.IsNullOrEmpty(keyValue))
            {
                expression = expression.And(t => t.F_EnCode.Contains(keyValue));
            }
            return service.IQueryable(expression).OrderBy(t => t.IGrowID).Single<ItemsEntity>().IGrowID;
        }
    }
}
