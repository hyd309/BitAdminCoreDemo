using System;
using System.Collections.Generic;

namespace BitAdminCoreDemo.Models
{
    public partial class SysUserClientId
    {
        public string ClientId { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
