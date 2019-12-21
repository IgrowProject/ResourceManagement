using IGrow.DataBase;
using IGrow.Entity.CommodityManage;
using System.Collections.Generic;

namespace IGrow.Domain.IRepository.CommodityManage
{
    public interface IComondityPlatformRepository : IRepositoryBase<ComondityPlatformEntity>
    {
        List<ComondityPlatformEntity> GetComondityPlatformList();
    }
}
