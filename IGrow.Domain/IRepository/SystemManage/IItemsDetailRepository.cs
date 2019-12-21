using IGrow.DataBase;
using IGrow.Entity.SystemManage;
using System.Collections.Generic;

namespace IGrow.Domain.IRepository.SystemManage
{
    public interface IItemsDetailRepository : IRepositoryBase<ItemsDetailEntity>
    {
        List<ItemsDetailEntity> GetItemList(string enCode);
    }
}
