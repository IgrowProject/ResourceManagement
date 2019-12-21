using IGrow.Entity.TradeManage;
using IGrow.Domain.IRepository.TradeManage;
using IGrow.Repository.TradeManage;
using System;
using System.Linq;
using System.Collections.Generic;
using IGrow.Code;

namespace IGrow.Application.TradeManage
{
    public class BudgetTargetApp
    {
        private IBudgetTargetRepository service = new BudgetTargetRepository();

        public List<BudgetTargetEntity> GetList(string keyword)
        {
            var expression = ExtLinq.True<BudgetTargetEntity>();
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.GrossMargin.Contains(keyword));
            }
            return service.IQueryable(expression).OrderByDescending(t => t.DeleteTime).ToList();
        } 
        public BudgetTargetEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(string keyValue)
        {
            service.Delete(t => t.IGrowID == keyValue);
        }
        public void SubmitForm(BudgetTargetEntity budgetEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                budgetEntity.Modify(keyValue);
                service.Update(budgetEntity);
            }
            else
            {
                budgetEntity.Create();
                service.Insert(budgetEntity);
            }
        }
    }
}
