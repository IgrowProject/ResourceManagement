using IGrow.Entity.TradeManage;
using IGrow.Domain.IRepository.TradeManage;
using IGrow.Repository.TradeManage;
using System;
using System.Linq;
using System.Collections.Generic;
using IGrow.Code;

namespace IGrow.Application.TradeManage
{
    public class BudgetProgressApp
    {
        private IBudgetProgressRepository service = new BudgetProgressRepository();

        public List<BudgetProgressEntity> GetList(string keyword)
        {
            var expression = ExtLinq.True<BudgetProgressEntity>();
            //if (!string.IsNullOrEmpty(keyword))
            //{
            //    expression = expression.And(t => t.OnBudget01.Contains(keyword));
            //}
            return service.IQueryable(expression).OrderByDescending(t => t.DeleteTime).ToList();
        } 
        public BudgetProgressEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(string keyValue)
        {
            service.Delete(t => t.IGrowID == keyValue);
        }
        public void SubmitForm(BudgetProgressEntity budgetEntity, string keyValue)
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
