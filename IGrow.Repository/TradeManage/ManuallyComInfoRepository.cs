using IGrow.DataBase;
using IGrow.Entity.TradeManage;
using IGrow.Domain.IRepository.TradeManage;
using IGrow.Repository.TradeManage;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;
using IGrow.Domain.Dto.Request;

namespace IGrow.Repository.TradeManage
{
    public class ManuallyComInfoRepository : RepositoryBase<ManuallyComInfoEntity>, IManuallyComInfoRepository
    {
        /// <summary>
        /// 获取商品订单列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<ManuallyComInfoEntity> GetManuallyComList(BaseRequest request)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT  *
                            FROM  Igrow_ManuallyComInfo
                            WHERE   1 = 1 
                                    AND Code IS NOT NULL 
                                    AND Code <> 'null' 
                                    AND CreateDate BETWEEN @StartTime AND @EndTime 
                                    AND DeleteMark = @DeleteMark 
                            ORDER BY CreateDate DESC");
            DbParameter[] parameter =
            {
                new SqlParameter("@StartTime",request.StartTime),
                new SqlParameter("@EndTime", request.EndTime),
                new SqlParameter("@DeleteMark", 1)
            };
            return this.FindList(strSql.ToString(), parameter);
        }
    }
}
