using IGrow.DataBase;
using IGrow.Entity.CommodityManage;
using System.Collections.Generic;

namespace IGrow.Domain.IRepository.CommodityManage
{
    public interface ICommodityInfoRepository : IRepositoryBase<CommodityInfoEntity> 
    {
        List<CommodityInfoEntity> GetCommodityList();
    }
}
