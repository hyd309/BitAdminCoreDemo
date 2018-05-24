using System;
using System.Collections.Generic;

namespace BitAdminCoreDemo.Models
{
    public partial class SysDepartment
    {
        public Guid DepartmentId { get; set; }
        public Guid? ParentId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentFullName { get; set; }
        public int? OrderNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? CreateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public Guid? PdateBy { get; set; }
    }
}
