using System;
using System.Collections.Generic;

namespace BitAdminCoreDemo.Models
{
    public partial class SysRoleOperatePower
    {
        public Guid Id { get; set; }
        public Guid? RoleId { get; set; }
        public Guid? ModulePageId { get; set; }
        public Guid? ModuleParentId { get; set; }
        public string OperationSign { get; set; }
    }
}
