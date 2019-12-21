using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using IGrow.Application.CommonService;
using System.Text;
using Igrow.Code.Excel; 
using System.Data;
using IGrow.Entity.TradeManage;
using IGrow.Application.TradeManage;

namespace IGrow.Web.Areas.Api.Controllers
{ 
    public class ExcelManageController : ControllerBasev2
    { 
        // GET: Api/ExcelManage
        public ActionResult Import(string table)
        {
            if (table != ""&& table.Length>= 0)
            {
                ViewData["templateUrl"] = "/Configs/Templates/template_customer.xls";
                ViewData["tableName"] = table;
            } 
            return View();
        }

        public ActionResult SubmitImport(HttpPostedFileBase filebase, string table)
        {
            HttpPostedFileBase file = Request.Files["file"];
            Stream stream = file.InputStream;
            if (file == null || file.ContentLength <= 0)
            {
                ViewBag.error = "文件不能为空";
                return View("Import");
            }
            else
            {
                //var filename = Path.GetFileName(fullPath);
                var filesize = file.ContentLength;//获取上传文件的大小单位为字节byte
                var fileEx = System.IO.Path.GetExtension(file.FileName);//获取上传文件的扩展名
                //var NoFileName = System.IO.Path.GetFileNameWithoutExtension(filename);//获取无扩展名的文件名
                var Maxsize = 4000 * 1024;//定义上传文件的最大空间大小为4M
                var FileType = ".xls,.xlsx";//定义上传文件的类型字符串
                if (!FileType.Contains(fileEx))
                {
                    ViewBag.error = "文件类型不对，只能导入xls和xlsx格式的文件";
                    return View("Import");
                }
                if (filesize >= Maxsize)
                {
                    ViewBag.error = "上传文件超过4M，不能上传";
                    return View("Import");
                }
                try
                {
                    //导入数据库写法  
                    //var dt = ExcelTool.ExcelToDataTable(true, fullPath);
                    var dt = ExcelTool.ReadStreamToDataTable(stream);
                    if (table != "" && table.Length >= 0)
                    {
                        if (table == "ManuallyCommInfo")//商品
                        {
                            new ManuallyComInfoApp().InputDate(dt);
                        }
                        if (table == "ManuallyTradeInfo")//订单
                        {
                            new ManuallyTradeInfoApp().InputDate(dt); 
                        }
                        if (table == "Refund")//退款
                        {
                            new RefundApp().InputDate(dt); 
                        }
                    }
                  }
                catch (Exception ex)
                {
                    ViewData["tableName"] = table;
                    ViewBag.error = ex.Message;
                    return View("Import");
                }
            }

            ViewData["tableName"] = table;
            ViewBag.error = "导入成功";
            System.Threading.Thread.Sleep(2000);
            return View("Import");
        }                
    }
}