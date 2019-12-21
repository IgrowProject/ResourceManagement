using IGrow.DataBase;
using IGrow.Domain.Dto.Request;
using IGrow.Entity.TradeManage;
using System.Collections.Generic;

namespace IGrow.Domain.IRepository.TradeManage
{
    public interface IManuallyComInfoRepository : IRepositoryBase<ManuallyComInfoEntity>
    {
        List<ManuallyComInfoEntity> GetManuallyComList(BaseRequest request);
    }
}

