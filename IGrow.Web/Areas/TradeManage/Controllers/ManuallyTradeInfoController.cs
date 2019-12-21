using IGrow.Application.TradeManage;
using IGrow.Code;
using IGrow.Entity.TradeManage;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace IGrow.Web.Areas.TradeManage.Controllers
{
    public class ManuallyTradeInfoController : ControllerBase
    {
        private ManuallyTradeInfoApp manuallyTradeInfoApp = new ManuallyTradeInfoApp();
 
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string queryJson)
        {
            pagination.sord = "asc";
            pagination.sidx = "OD20";
            var data = manuallyTradeInfoApp.GetList(pagination, queryJson);
            return DataGrid(pagination.total, data);
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = manuallyTradeInfoApp.GetForm(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(ManuallyTradeInfoEntity manuallyTradeInfoEntity, string keyValue)
        {
            manuallyTradeInfoApp.SubmitForm(manuallyTradeInfoEntity, keyValue);
            return Success("操作成功。");
        } 
    }
}
