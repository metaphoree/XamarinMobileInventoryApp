using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Dto
{
    public class MasterPageItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
    }
}
