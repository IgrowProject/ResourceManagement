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
    public class RefundApp
    {
        private IRefundRepository service = new RefundRepository();

          public List<RefundEntity> GetList(Pagination pagination, string queryJson)
        {
            var expression = ExtLinq.True<RefundEntity>();
            var queryParam = queryJson.ToJObject(); 
            if (!queryParam["ComCode"].IsEmpty())
            {
                string ComCode = queryParam["ComCode"].ToString();
                expression = expression.And(t => t.OnRefund00.Contains(ComCode));
            }
            if (!queryParam["ComName"].IsEmpty())
            {
                string ComName = queryParam["ComName"].ToString();
                expression = expression.And(t => t.OnRefund01.Contains(ComName));
            }
            if (!queryParam["TstartTime"].IsEmpty())
            {
                DateTime strart = TimeFormat.StarTime(queryParam["TstartTime"].ToString());
                expression = expression.And(t => t.OnRefund03 >= strart);
            }
            if (!queryParam["TendTime"].IsEmpty())
            {
                DateTime end = TimeFormat.StarTime(queryParam["TendTime"].ToString());
                expression = expression.And(t => t.OnRefund03 <= end);
            }
            return service.FindList(expression, pagination);
        }
        public RefundEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void InputDate(DataTable dt)
        {
            if (dt != null || dt.Rows.Count > 0)
            {
                List<RefundEntity> listRefund = new List<RefundEntity>();
                foreach (DataRow item in dt.Rows)
                {
                    var refundInfo = new RefundEntity();
                    refundInfo.IGrowID = Guid.NewGuid().ToString();
                    refundInfo.OnRefund00 = item[0].ToString();                    
                    refundInfo.OnRefund01 = item[1].ToString();
                    refundInfo.OnRefund02 = item[2].ToString();
                    refundInfo.OnRefund03 = DataConvert.DateTimeConvert(item[3].ToString());
                    refundInfo.OnRefund04 = item[4].ToString();
                    refundInfo.OnRefund05 = DataConvert.DateTimeConvert(item[5].ToString());
                    refundInfo.OnRefund06 = item[6].ToString();
                    refundInfo.OnRefund07 = Convert.ToDouble(item[7].ToString());
                    refundInfo.OnRefund08 = item[8].ToString();
                    refundInfo.OnRefund09 = Convert.ToDouble(item[9].ToString());
                    refundInfo.OnRefund10 = item[10].ToString();
                    refundInfo.OnRefund11 = item[11].ToString();
                    refundInfo.OnRefund12 = DataConvert.DateTimeConvert(item[12].ToString());
                    refundInfo.OnRefund13 = DataConvert.DateTimeConvert(item[13].ToString());
                    refundInfo.OnRefund14 = item[14].ToString();
                    refundInfo.OnRefund15 = item[15].ToString();
                    refundInfo.OnRefund16 = item[16].ToString();
                    refundInfo.OnRefund17 = item[17].ToString();
                    refundInfo.OnRefund18 = item[18].ToString();
                    refundInfo.OnRefund19 = item[19].ToString();
                    refundInfo.OnRefund20 = item[20].ToString();
                    refundInfo.OnRefund21 = item[21].ToString();
                    refundInfo.OnRefund22 = item[22].ToString();
                    refundInfo.OnRefund23 = item[23].ToString();
                    refundInfo.OnRefund24 = item[24].ToString();
                    refundInfo.OnRefund25 = item[25].ToString();
                    refundInfo.OnRefund26 = item[26].ToString();
                    refundInfo.OnRefund27 = item[27].ToString();
                    refundInfo.OnRefund28 = item[28].ToString();
                    refundInfo.OnRefund29 = item[29].ToString();
                    refundInfo.OnRefund30 = item[30].ToString();
                    refundInfo.OnRefund31 = item[31].ToString();
                    refundInfo.OnRefund32 = item[32].ToString();
                    refundInfo.OnRefund33 = item[33].ToString();
                    refundInfo.OnRefund34 = item[34].ToString();
                    refundInfo.OnRefund35 = item[35].ToString();
                    refundInfo.OnRefund36 = item[36].ToString();
                    refundInfo.OnRefund37 = item[37].ToString();
                    refundInfo.OnRefund38 = item[38].ToString();
                    //refundInfo.Description = item[].ToString();
                    refundInfo.CreateDate = DateTime.Now;
                    refundInfo.CreatorUserId = "";
                    refundInfo.ModifyDate = null;
                    refundInfo.ModifyUserId = "";
                    refundInfo.DeleteMark = true;
                    refundInfo.DeleteTime = null;
                    refundInfo.DeleteUserId = "";
                    listRefund.Add(refundInfo);
                }
                service.Insert(listRefund);
            }
        } 
    }
}
