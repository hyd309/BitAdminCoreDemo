using System;
using System.Collections.Generic;

namespace BitAdminCoreDemo.Models
{
    public partial class SysPageOperation
    {
        public Guid Id { get; set; }
        public Guid? PageId { get; set; }
        public string OperationSign { get; set; }
    }
}
