using System;
using System.Collections.Generic;

namespace BitAdminCoreDemo.Models
{
    public partial class FlowOrderCodes
    {
        public int Id { get; set; }
        public string Pinyin { get; set; }
        public string Day { get; set; }
        public int Index { get; set; }
        public string Code { get; set; }
    }
}
