using IGrow.Code;
using IGrow.Entity.CommodityManage;
using IGrow.Domain.IRepository.CommodityManage;
using IGrow.Repository.CommodityManage;
using System;
using System.Collections.Generic; 
 
namespace IGrow.Application.CommodityManage
{
    public class CommodityInfoApp
    {
       private ICommodityInfoRepository service  = new CommodityInfoRepository(); 

        public List<CommodityInfoEntity> GetList(Pagination pagination, string queryJson)
        {
            var expression = ExtLinq.True<CommodityInfoEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["ComCode"].IsEmpty())
            {
                string ComCode = queryParam["ComCode"].ToString();
                expression = expression.And(t => t.Code.Contains(ComCode));
            }
            if (!queryParam["ComName"].IsEmpty())
            {
                string ComName = queryParam["ComName"].ToString();
                expression = expression.And(t => t.Name.Contains(ComName));
            }
            return service.FindList(expression, pagination);
        }
        public CommodityInfoEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void SubmitForm(CommodityInfoEntity commodityInfoEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                commodityInfoEntity.Modify(keyValue);
                service.Update(commodityInfoEntity);
            }
            else
            {
                commodityInfoEntity.Create(); 
                service.Insert(commodityInfoEntity);
            }
        }
    }
}
