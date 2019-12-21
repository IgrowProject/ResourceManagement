using IGrow.Application.TradeManage;
using IGrow.Code;
using IGrow.Domain.Dto.Request;
using IGrow.Entity.TradeManage;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace IGrow.Web.Areas.TradeManage.Controllers
{
    public class ManuallyComProfitController : ControllerBase
    {
        private ManuallyComProfitApp profitApp = new ManuallyComProfitApp();

        //[HttpGet]
        //[HandlerAjaxOnly]
        //public ActionResult GetGridJson(string keyword)
        //{
        //    var data = profitApp.GetList(keyword);
        //    return Content(data.ToJson());
        //}
        //[HttpGet]
        //[HandlerAjaxOnly]
        //public ActionResult GetFormJson(string keyValue)
        //{
        //    var data = profitApp.GetForm(keyValue);
        //    return Content(data.ToJson());
        //} 
        //[HttpPost]
        //[HandlerAjaxOnly]
        //[ValidateAntiForgeryToken]
        //public ActionResult SubmitForm(ManuallyComProfitEntity profitEntity, string keyValue)
        //{
        //    profitApp.SubmitForm(profitEntity, keyValue);
        //    return Success("操作成功。");
        //}

        [HttpPost]
        [HandlerAjaxOnly]
        public ActionResult GetComInfo(BaseRequest request)
        {
            var data = profitApp.GetComInfo(request);
            return Content(data.ToJson());
        }

    }
}
