﻿/*******************************************************************************
 * Copyright © 2019 .Framework 版权所有
 * Author: DaleCloud
 * Description: 快速开发平台
 * Website：
*********************************************************************************/
using IGrow.Application.SystemSecurity;
using IGrow.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IGrow.Web.Areas.SystemSecurity.Controllers
{
    public class LogController : ControllerBase
    {
        private LogApp logApp = new LogApp();

        [HttpGet]
        public ActionResult RemoveLog()
        {
            return View();
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string queryJson)
        {
            pagination.sord = "asc";
            pagination.sidx = "F_Date";
            var data = logApp.GetList(pagination, queryJson);
            return DataGrid(pagination.total,data);
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitRemoveLog(string keepTime)
        {
            logApp.RemoveLog(keepTime);
            return Success("清空成功。");
        }
    }
}
