using IGrow.Entity.TradeManage;
using IGrow.Domain.IRepository.TradeManage;
using IGrow.Repository.TradeManage;
using System;
using System.Linq;
using System.Collections.Generic;
using IGrow.Code;
using System.Data;

namespace IGrow.Application.TradeManage
{
    public class ManuallyComInfoApp
    {
        private IManuallyComInfoRepository service = new ManuallyComInfoRepository();

        public List<ManuallyComInfoEntity> GetList(Pagination pagination, string queryJson)
        {
            var expression = ExtLinq.True<ManuallyComInfoEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["ComCode"].IsEmpty())
            {
                string ComCode = queryParam["ComCode"].ToString();
                expression = expression.And(t => t.Platform_code.Contains(ComCode));
            }
            if (!queryParam["ComName"].IsEmpty())
            {
                string ComName = queryParam["ComName"].ToString();
                expression = expression.And(t => t.Code.Contains(ComName));
            } 
            if (!queryParam["TstartTime"].IsEmpty())
            {
                DateTime strart = TimeFormat.StarTime(queryParam["TstartTime"].ToString());
                expression = expression.And(t => t.CreateDate >= strart);
            }
            if (!queryParam["TendTime"].IsEmpty())
            {
                DateTime end = TimeFormat.StarTime(queryParam["TendTime"].ToString());
                expression = expression.And(t => t.CreateDate <= end);
            }
            return service.FindList(expression, pagination);
        }
        public ManuallyComInfoEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void InputDate(DataTable dt)
        {
            if (dt != null || dt.Rows.Count > 0) 
            {
                List<ManuallyComInfoEntity> listComInfo = new List<ManuallyComInfoEntity>();
                foreach (DataRow item in dt.Rows)
                {
                    var ComInfo = new ManuallyComInfoEntity();
                    ComInfo.IGrowID = Guid.NewGuid().ToString();
                    ComInfo.Platform_code = item[0].ToString();
                    ComInfo.SpuName = item[1].ToString();
                    ComInfo.Price = Convert.ToDecimal(item[2].ToString());
                    ComInfo.Amount = Convert.ToInt16(item[3].ToString());
                    ComInfo.SkuCode = item[4].ToString();
                    ComInfo.SkuName = item[5].ToString();
                    ComInfo.Note = item[6].ToString();
                    ComInfo.Remarks = item[7].ToString();
                    ComInfo.DState = item[8].ToString();
                    ComInfo.Code =item[9].ToString();                    
                    ComInfo.CreateDate = DateTime.Now;
                    ComInfo.CreatorUserId = "System";
                    ComInfo.ModifyDate = null;
                    ComInfo.ModifyUserId = "";
                    ComInfo.DeleteMark = true;
                    ComInfo.DeleteTime = null;
                    ComInfo.DeleteUserId = "";
                    listComInfo.Add(ComInfo);
                }
                service.Insert(listComInfo);
            }
        } 
        public void SubmitForm(ManuallyComInfoEntity manuallyComInfoEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                manuallyComInfoEntity.Modify(keyValue);
                service.Update(manuallyComInfoEntity);
            }
            else
            {
                manuallyComInfoEntity.Create();
                service.Insert(manuallyComInfoEntity);
            }
        }
    }
}
