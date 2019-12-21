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
    public class ManuallyTradeInfoApp
    {
        private IManuallyTradeInfoRepository service = new ManuallyTradeInfoRepository(); 
        public List<ManuallyTradeInfoEntity> GetList(Pagination pagination, string queryJson)
        {
            var expression = ExtLinq.True<ManuallyTradeInfoEntity>();
            var queryParam = queryJson.ToJObject(); 
            if (!queryParam["ComCode"].IsEmpty())
            {
                string ComCode = queryParam["ComCode"].ToString();
                expression = expression.And(t => t.OD01.Contains(ComCode));
            }
            if (!queryParam["ComName"].IsEmpty())
            {
                string ComName = queryParam["ComName"].ToString();
                expression = expression.And(t => t.OD04.Contains(ComName));
            } 
            if (!queryParam["TstartTime"].IsEmpty())
            {
                DateTime strart = TimeFormat.StarTime(queryParam["TstartTime"].ToString());
                expression = expression.And(t => t.OD20 >= strart); 
            }
            if (!queryParam["TendTime"].IsEmpty())
            {
                DateTime end = TimeFormat.StarTime(queryParam["TendTime"].ToString());
                expression = expression.And(t => t.OD20 <= end); 
            }
            return service.FindList(expression, pagination);
        }
        public ManuallyTradeInfoEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        } 
        public void SubmitForm(ManuallyTradeInfoEntity manuallyTradeInfo, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                manuallyTradeInfo.Modify(keyValue);
                service.Update(manuallyTradeInfo);
            }
            else
            {
                manuallyTradeInfo.Create();
                service.Insert(manuallyTradeInfo);
            }
        }
        public void InputDate(DataTable dt)
        {
            if (dt != null || dt.Rows.Count > 0)
            {
                List<ManuallyTradeInfoEntity> listRefund = new List<ManuallyTradeInfoEntity>();
                foreach (DataRow item in dt.Rows)
                {
                    var refundInfo = new ManuallyTradeInfoEntity
                    {
                        #region 字段赋值
                        IGrowID = Guid.NewGuid().ToString(),
                        OD01 = item[0].ToString(),
                        OD02 = item[1].ToString(),
                        OD03 = item[2].ToString(),
                        OD04 = item[3].ToString(),
                        OD05 = item[4].ToString(),
                        OD06 = item[5].ToString(),
                        OD07 = item[6].ToString(),
                        OD08 = item[7].ToString(),
                        OD09 = item[8].ToString(),
                        OD10 = item[9].ToString(),
                        OD11 = item[10].ToString(),
                        OD12 = item[11].ToString(),
                        OD13 = item[12].ToString(),
                        OD14 = item[13].ToString(),
                        OD15 = item[14].ToString(),
                        OD16 = item[15].ToString(),
                        OD17 = item[16].ToString(),
                        OD18 = item[17].ToString(),
                        OD19 = item[18].ToString(),
                        OD20 = DataConvert.DateTimeConvert(item[19].ToString()),
                        OD21 = DataConvert.DateTimeConvert(item[20].ToString()),
                        OD22 = item[21].ToString(),
                        OD23 = item[22].ToString(),
                        OD24 = item[23].ToString(),
                        OD25 = item[24].ToString(),
                        OD26 = item[25].ToString(),
                        OD27 = item[26].ToString(),
                        OD28 = item[27].ToString(),
                        OD29 = item[28].ToString(),
                        OD30 = item[29].ToString(),
                        OD31 = item[30].ToString(),
                        OD32 = item[31].ToString(),
                        OD33 = item[32].ToString(),
                        OD34 = item[33].ToString(),
                        OD35 = item[34].ToString(),
                        OD36 = item[35].ToString(),
                        OD37 = item[36].ToString(),
                        OD38 = item[37].ToString(),
                        OD39 = item[38].ToString(),
                        OD40 = item[39].ToString(),
                        OD41 = item[40].ToString(),
                        OD42 = item[41].ToString(),
                        OD43 = item[42].ToString(),
                        OD44 = item[43].ToString(),
                        OD45 = item[44].ToString(),
                        OD46 = item[45].ToString(),
                        OD47 = item[46].ToString(),
                        OD48 = item[47].ToString(),
                        OD49 = item[48].ToString(),
                        OD50 = item[49].ToString(),
                        OD51 = item[50].ToString(),
                        OD52 = item[51].ToString(),
                        OD53 = item[52].ToString(),
                        OD54 = item[53].ToString(),
                        OD55 = item[54].ToString(),
                        OD56 = item[55].ToString(),
                        OD57 = item[56].ToString(),
                        OD58 = item[57].ToString(),
                        OD59 = item[58].ToString(),
                        OD60 = item[59].ToString(),
                        OD61 = item[60].ToString(),
                        OD62 = item[61].ToString(),
                        OD63 = item[62].ToString(),
                        OD64 = item[63].ToString(),
                        OD65 = item[64].ToString(),
                        OD66 = item[65].ToString(),
                        OD67 = item[66].ToString(),
                        OD68 = item[67].ToString(),
                        OD69 = item[68].ToString(),
                        CreateDate = DateTime.Now,
                        CreatorUserId = "",
                        ModifyDate = null,
                        ModifyUserId = item[43].ToString(),
                        DeleteMark = true,
                        DeleteTime = null,
                        DeleteUserId = ""
                        #endregion
                    };
                    listRefund.Add(refundInfo);
                }
                service.Insert(listRefund);
            }
        }

    }
}
