using IGrow.DataBase;
using IGrow.Domain.IRepository.CommodityManage;
using IGrow.Entity.CommodityManage;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace IGrow.Repository.CommodityManage
{
  public class CommodityInfoRepository : RepositoryBase<CommodityInfoEntity>, ICommodityInfoRepository 
    {
        /// <summary>
        /// 获取商品基础列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<CommodityInfoEntity> GetCommodityList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT  * 
                            FROM  Igrow_CommodityInfo 
                            WHERE   1 = 1 
                                    AND Del = @Del 
                                ORDER BY CreateDate DESC");
            DbParameter[] parameter =
            {
                new SqlParameter("@Del", false)
            };
            return this.FindList(strSql.ToString(), parameter);
        }
    }
}
