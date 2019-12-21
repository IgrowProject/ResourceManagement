using IGrow.Entity.TradeManage;
using IGrow.Domain.IRepository.TradeManage;
using IGrow.Repository.TradeManage;
using System;
using System.Linq;
using System.Collections.Generic;

using IGrow.Code;
using IGrow.Domain.Dto.Request;
using IGrow.Domain.IRepository.CommodityManage;
using IGrow.Repository.CommodityManage;

namespace IGrow.Application.TradeManage
{
    public class ManuallyComProfitApp
    {
        private IManuallyComInfoRepository manuallyComInfoRepository = new ManuallyComInfoRepository();
        private IComondityPlatformRepository comondityPlatformRepository = new ComondityPlatformRepository();
        private ICommodityInfoRepository commodityInfoRepository = new CommodityInfoRepository();

        //private IManuallyComProfitRepository service = new ManuallyComProfitRepository();

        //public List<ManuallyComProfitEntity> GetList(string keyword)
        //{
        //    var expression = ExtLinq.True<ManuallyComProfitEntity>();
        //    //if (!string.IsNullOrEmpty(keyword))
        //    //{
        //    //    expression = expression.And(t => t.F_Name.Contains(keyword));
        //    //}
        //    return service.IQueryable(expression).OrderByDescending(t => t.DeleteTime).ToList();
        //}
        //public ManuallyComProfitEntity GetForm(string keyValue)
        //{
        //    return service.FindEntity(keyValue);
        //}
        //public void DeleteForm(string keyValue)
        //{
        //    service.Delete(t => t.IGrowID == keyValue);
        //}
        //public void SubmitForm(ManuallyComProfitEntity profitEntity, string keyValue)
        //{
        //    if (!string.IsNullOrEmpty(keyValue))
        //    {
        //        profitEntity.Modify(keyValue);
        //        service.Update(profitEntity);
        //    }
        //    else
        //    {
        //        profitEntity.Create();
        //        service.Insert(profitEntity);
        //    }
        //}


        public object GetComInfo(BaseRequest request)
        {
            //商品订单表
            List<ManuallyComInfoEntity> ManuallyComList = manuallyComInfoRepository.GetManuallyComList(request);
            //平台铺货表
            var ComondityPlatformList = comondityPlatformRepository.GetComondityPlatformList();
            //商品基础表
            var CommodityList = commodityInfoRepository.GetCommodityList();
            var result = from manuallyCom in ManuallyComList
                         join platform in ComondityPlatformList
                         on manuallyCom.Code equals platform.Code
                         join commodity in CommodityList
                         on manuallyCom.Code equals commodity.Code
                         select new
                         {
                             manuallyCom.Amount,
                             manuallyCom.Price,
                             manuallyCom.Code,
                             platform.SpuID,
                             platform.SkuName,
                             commodity.PurchasePrice
                         };
            return result;
        }
    }
}
