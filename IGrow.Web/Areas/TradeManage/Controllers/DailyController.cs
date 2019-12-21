using IGrow.Application.TradeManage;
using IGrow.Code;
using IGrow.Entity.TradeManage;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace IGrow.Web.Areas.TradeManage.Controllers
{
    public class DailyController : ControllerBase
    {
        private DailyApp dailyApp = new DailyApp(); 
 
        public ActionResult GetGridJson(Pagination pagination, string queryJson)
        {
            pagination.sord = "asc";
            pagination.sidx = "CreateDate";
            var data = dailyApp.GetList(pagination, queryJson);
            return DataGrid(pagination.total, data);
        } 
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = dailyApp.GetForm(keyValue);
            return Content(data.ToJson());
        } 
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(DailyEntity dailyEntity, string keyValue)
        {
            dailyApp.SubmitForm(dailyEntity, keyValue);
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            dailyApp.DeleteForm(keyValue);
            return Success("删除成功。");
        }
        [HttpGet]
        public ActionResult RevisePassword()
        {
            return View();
        } 
        [HttpGet]
        public ActionResult Info()
        {
            return View();
        }
    }
}
