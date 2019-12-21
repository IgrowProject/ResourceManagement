using IGrow.DataBase;
using IGrow.Domain.IRepository.CommodityManage;
using IGrow.Entity.CommodityManage;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace IGrow.Repository.CommodityManage
{
    public class ComondityPlatformRepository : RepositoryBase<ComondityPlatformEntity>, IComondityPlatformRepository
    {
        /// <summary>
        /// 获取平台铺货列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<ComondityPlatformEntity> GetComondityPlatformList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT  *
                            FROM  Igrow_ComondityPlatform
                            WHERE   1 = 1 
                                    AND Code IS NOT NULL 
                                    AND Code <> 'NULL' 
                                    AND ShopID = @ShopID 
                                    AND SkuId <> @SkuId");
            DbParameter[] parameter =
            {
                //TODO 参数需要传入？
                new SqlParameter("@ShopID", 1),
                new SqlParameter("@SkuId", -1)
            };
            return this.FindList(strSql.ToString(), parameter);
        }
    }
}
