using IGrow.Application.TradeManage;
using IGrow.Code;
using IGrow.Entity.TradeManage;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace IGrow.Web.Areas.TradeManage.Controllers
{
    public class RefundController : ControllerBase
    {
        private RefundApp refundApp = new RefundApp();

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string queryJson)
        {
            pagination.sord = "desc";
            pagination.sidx = "CreateDate";
            var data = refundApp.GetList(pagination, queryJson);
            return DataGrid(pagination.total, data);
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = refundApp.GetForm(keyValue);
            return Content(data.ToJson());
        } 
    }
}
