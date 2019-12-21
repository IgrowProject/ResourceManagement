/*******************************************************************************
 * Copyright © 2019 .Framework 版权所有
 * Author: DaleCloud
 * Description: 快速开发平台
 * Website：
*********************************************************************************/

using System.Collections.Generic;
using System.Linq;
using System;
using System.Web.Mvc;
using IGrow.Code;
using DaleCloud.Application.WeixinManage;
using IGrow.Entity.WeixinManage;
namespace DaleCloud.Web.Areas.WeixinManage.Controllers
{
    public class WxCodeController : ControllerBase
    {
        private WxBaseConfigApp app = new WxBaseConfigApp();
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(string keyword)
        {
            var data = app.GetList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = app.GetForm(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(WxBaseConfigEntity userEntity, string keyValue)
        {
            app.SubmitForm(userEntity, keyValue);
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            app.DeleteForm(keyValue);
            return Success("删除成功。");
        }
        
        
    }
}
