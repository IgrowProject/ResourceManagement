using IGrow.Application.CommodityManage;
using IGrow.Code;
using IGrow.Entity.CommodityManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IGrow.Web.Areas.CommodityManage.Controllers
{
    public class CommodityInfoController : ControllerBase
    {
        private CommodityInfoApp commodityInfoApp = new CommodityInfoApp();
         
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string queryJson)
        {
            pagination.sord = "desc";
            pagination.sidx = "CreateDate";
            var data = commodityInfoApp.GetList(pagination, queryJson);
            return DataGrid(pagination.total,data);
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = commodityInfoApp.GetForm(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(CommodityInfoEntity commodityInfoEntity, string keyValue)
        {
            commodityInfoApp.SubmitForm(commodityInfoEntity, keyValue);
            return Success("操作成功。");
        }
    }
}
