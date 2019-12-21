using IGrow.Entity.TradeManage;
using IGrow.Domain.IRepository.TradeManage;
using IGrow.Repository.TradeManage;
using System;
using System.Linq;
using System.Collections.Generic;

using IGrow.Code;

namespace IGrow.Application.TradeManage
{
    public class DailyApp
    {
        private IDailyRepository service = new DailyRepository();
 
        public List<DailyEntity> GetList(Pagination pagination, string queryJson)
        {
            var expression = ExtLinq.True<DailyEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.OnDaily01.Contains(keyword));
            } 
            return service.FindList(expression, pagination);
        }
        public DailyEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(string keyValue)
        {
            service.Delete(t => t.IGrowID == keyValue);
        }
        public void SubmitForm(DailyEntity dailyEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                dailyEntity.Modify(keyValue);
                service.Update(dailyEntity);
            }
            else
            {
                dailyEntity.Create();
                service.Insert(dailyEntity);
            }
        }
    }
}
