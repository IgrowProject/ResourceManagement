using IGrow.Application.CommodityManage;
using IGrow.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IGrow.Web.Areas.CommodityManage.Controllers
{
    public class ComondityPlatformController : ControllerBase
    {
        private ComondityPlatformApp ComondityPlatformApp = new ComondityPlatformApp();
         
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string queryJson)
        {
            pagination.sord = "desc";
            pagination.sidx = "ModifyDate";
            var data = ComondityPlatformApp.GetList(pagination, queryJson);
            return DataGrid(pagination.total,data);
        }
         
    }
}
