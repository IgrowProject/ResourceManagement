
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using IGrow.Code;
using IGrow.Entity.BaseDataManage;
using IGrow.Repository.BaseDataManage;
using IGrow.DataBase;

namespace IGrow.Application.CommonService
{
    public class BaseAttachApp
    {
        private BaseAttachRepository server = new BaseAttachRepository();

        public List<BaseAttachEntity> GetList()
        {
            return server.IQueryable().ToList();
        }

        public List<BaseAttachEntity> GetMapList(string objectId = "")
        {
            var expression = ExtLinq.True<BaseAttachEntity>();
            if (!string.IsNullOrEmpty(objectId))
            {
                expression = expression.And(t => t.T_DocId.Contains(objectId));
            }
            return server.IQueryable(expression).OrderBy(t => t.CreateDate).ToList();
        }

        public BaseAttachEntity GetForm(string keyValue)
        {
            return server.FindEntity(keyValue);
        }
       

        private void DeleteForm(string objectId, string fileId="")
        {
            if (string.IsNullOrEmpty(fileId))
            {
                server.Delete(t => t.T_DocId == objectId);
            }else
            {
                server.Delete(t => t.T_DocId == objectId && t.IGrowID == fileId);
            }
        }

        public void SubmitForm(string objectId,string filpath)
        {
            if (!string.IsNullOrEmpty(objectId))
            {
                BaseAttachEntity entity = new BaseAttachEntity();
                entity.IGrowID = CommonUtils.GuId();
                entity.CreateDate = DateTime.Now;
                entity.T_DocId = objectId;
                entity.T_Path = filpath;
                server.Insert(entity);
                
            }
        }

      
    }
    
}
