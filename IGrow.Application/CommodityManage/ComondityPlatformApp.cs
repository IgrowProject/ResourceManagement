using IGrow.Code;
using IGrow.Entity.CommodityManage;
using IGrow.Domain.IRepository.CommodityManage;
using IGrow.Repository.CommodityManage;
using System;
using System.Collections.Generic;

namespace IGrow.Application.CommodityManage
{
    public class ComondityPlatformApp
    {
        private IComondityPlatformRepository service  = new ComondityPlatformRepository();

        public List<ComondityPlatformEntity> GetList(Pagination pagination, string queryJson)
        {
            var expression = ExtLinq.True<ComondityPlatformEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["SpuID"].IsEmpty())
            {
                string SpuID = queryParam["SpuID"].ToString();
                expression = expression.And(t => t.SpuID.ToString().Contains(SpuID));
            }
            if (!queryParam["SkuId"].IsEmpty())
            {
                string SkuId = queryParam["SkuId"].ToString();
                expression = expression.And(t => t.SkuId.ToString().Contains(SkuId));
            }
            if (!queryParam["ComCode"].IsEmpty())
            {
                string ComCode = queryParam["ComCode"].ToString();
                expression = expression.And(t => t.SkuCode.Contains(ComCode));
            }
            if (!queryParam["ComName"].IsEmpty())
            {
                string ComName = queryParam["ComName"].ToString();
                expression = expression.And(t => t.SkuName.Contains(ComName));
            }
            return service.FindList(expression, pagination);
        }

    }
}
