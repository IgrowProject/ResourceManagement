using IGrow.Application.TradeManage;
using IGrow.Code;
using IGrow.Entity.TradeManage;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace IGrow.Web.Areas.TradeManage.Controllers
{
    public class BudgetController : ControllerBase
    {
        private BudgetProgressApp budgetApp = new BudgetProgressApp();
        //private UserLogOnApp userLogOnApp = new UserLogOnApp();
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(string keyword)
        {
            var data = budgetApp.GetList(keyword);
            return Content(data.ToJson());
        } 
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = budgetApp.GetForm(keyValue);
            return Content(data.ToJson());
        } 
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(BudgetProgressEntity budgetEntity, string keyValue)
        {
            budgetApp.SubmitForm(budgetEntity, keyValue);
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            budgetApp.DeleteForm(keyValue);
            return Success("删除成功。");
        }
        [HttpGet]
        public ActionResult RevisePassword()
        {
            return View();
        }
        //[HttpPost]
        //[HandlerAjaxOnly]
        //[HandlerAuthorize]
        //[ValidateAntiForgeryToken]
        //public ActionResult SubmitRevisePassword(string userPassword, string keyValue)
        //{
        //    userLogOnApp.RevisePassword(userPassword, keyValue);
        //    return Success("重置密码成功。");
        //}
        //[HttpPost]
        //[HandlerAjaxOnly]
        //[HandlerAuthorize]
        //[ValidateAntiForgeryToken]
        //public ActionResult DisabledAccount(string keyValue)
        //{
        //    UserEntity userEntity = new UserEntity();
        //    userEntity.IGrowID = keyValue;
        //    userEntity.F_EnabledMark = false;
        //    userApp.UpdateForm(userEntity);
        //    return Success("账户禁用成功。");
        //}
        //[HttpPost]
        //[HandlerAjaxOnly]
        //[HandlerAuthorize]
        //[ValidateAntiForgeryToken]
        //public ActionResult EnabledAccount(string keyValue)
        //{
        //    UserEntity userEntity = new UserEntity();
        //    userEntity.IGrowID = keyValue;
        //    userEntity.F_EnabledMark = true;
        //    userApp.UpdateForm(userEntity);
        //    return Success("账户启用成功。");
        //}

        [HttpGet]
        public ActionResult Info()
        {
            return View();
        }
    }
}
