using System;
using System.Collections.Generic;

namespace BitAdminCoreDemo.Models
{
    public partial class SysLeader
    {
        public Guid LeaderId { get; set; }
        public string DepartmentCode { get; set; }
        public string UserCode { get; set; }
        public string Pos { get; set; }
        public string Sequence { get; set; }
    }
}
