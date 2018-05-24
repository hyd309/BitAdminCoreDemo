using System;
using System.Collections.Generic;

namespace BitAdminCoreDemo.Models
{
    public partial class SysModulePage
    {
        public Guid Id { get; set; }
        public Guid? ModuleId { get; set; }
        public string PageSign { get; set; }
        public string PageName { get; set; }
        public string PageIcon { get; set; }
        public string PageUrl { get; set; }
        public string Description { get; set; }
        public int? OrderNo { get; set; }
    }
}
