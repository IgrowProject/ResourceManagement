using IGrow.Application.TradeManage;
using IGrow.Code;
using IGrow.Entity.TradeManage;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace IGrow.Web.Areas.TradeManage.Controllers
{
    public class ManuallyTraProfitController : ControllerBase
    {
        private ManuallyTraProfitApp profitApp = new ManuallyTraProfitApp(); 

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(string keyword)
        {
            var data = profitApp.GetList(keyword);
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = profitApp.GetForm(keyValue);
            return Content(data.ToJson());
        } 
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(ManuallyTraProfitEntity profitEntity, string keyValue)
        {
            profitApp.SubmitForm(profitEntity, keyValue);
            return Success("操作成功。");
        }
      
        
    }
}
