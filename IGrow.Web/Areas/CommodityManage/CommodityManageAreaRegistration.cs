using System.Web.Mvc;

namespace IGrow.Web.Areas.CommodityManage
{
    public class CommodityManageAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "CommodityManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
              this.AreaName + "_Default",
              this.AreaName + "/{controller}/{action}/{id}",
              new { area = this.AreaName, controller = "Home", action = "Index", id = UrlParameter.Optional },
              new string[] { "IGrow.Web.Areas." + this.AreaName + ".Controllers" }
            );
        }
    }
}
