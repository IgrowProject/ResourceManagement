using System;

namespace IGrow.Entity.SystemManage
{
    public class RoleEntity : IEntity<RoleEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public string IGrowID { get; set; }
        public string F_OrganizeId { get; set; }
        public int? F_Category { get; set; }
        public string F_EnCode { get; set; }
        public string F_FullName { get; set; }
        public string F_Type { get; set; }
        public bool? F_AllowEdit { get; set; }
        public bool? F_AllowDelete { get; set; }
        public int? F_SortCode { get; set; }
        public bool? DeleteMark { get; set; }
        public bool? F_EnabledMark { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatorUserId { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public DateTime? DeleteTime { get; set; }
        public string DeleteUserId { get; set; }
    }
}
