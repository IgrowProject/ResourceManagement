using IGrow.Application.TradeManage;
using IGrow.Code;
using IGrow.Entity.TradeManage;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace IGrow.Web.Areas.TradeManage.Controllers
{
    public class ManuallyComInfoController : ControllerBase
    {
        private ManuallyComInfoApp manuallyComInfoApp = new ManuallyComInfoApp();

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string queryJson)
        {
            pagination.sord = "desc";
            pagination.sidx = "CreateDate";
            var data = manuallyComInfoApp.GetList(pagination, queryJson);
            return DataGrid(pagination.total, data);
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = manuallyComInfoApp.GetForm(keyValue);
            return Content(data.ToJson());
        } 
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(ManuallyComInfoEntity ManuallyComInfoEntity, string keyValue)
        {
            manuallyComInfoApp.SubmitForm(ManuallyComInfoEntity, keyValue);
            return Success("操作成功。");
        }
         
    }
}
