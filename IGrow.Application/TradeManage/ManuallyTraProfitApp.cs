using IGrow.Entity.TradeManage;
using IGrow.Domain.IRepository.TradeManage;
using IGrow.Repository.TradeManage;
using System;
using System.Linq;
using System.Collections.Generic;

using IGrow.Code;

namespace IGrow.Application.TradeManage
{
    public class ManuallyTraProfitApp
    {
        private IManuallyTraProfitRepository service = new ManuallyTraProfitRepository();

        public List<ManuallyTraProfitEntity> GetList(string keyword)
        {
            var expression = ExtLinq.True<ManuallyTraProfitEntity>();
            //if (!string.IsNullOrEmpty(keyword))
            //{
            //    expression = expression.And(t => t.F_Name.Contains(keyword));
            //}
            return service.IQueryable(expression).OrderByDescending(t => t.DeleteTime).ToList();
        }
        public ManuallyTraProfitEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(string keyValue)
        {
            service.Delete(t => t.IGrowID == keyValue);
        }
        public void SubmitForm(ManuallyTraProfitEntity profitEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                profitEntity.Modify(keyValue);
                service.Update(profitEntity);
            }
            else
            {
                profitEntity.Create();
                service.Insert(profitEntity);
            }
        }
    }
}
