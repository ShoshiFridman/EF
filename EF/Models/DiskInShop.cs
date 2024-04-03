using System;
using System.Collections.Generic;

namespace EF.Models
{
    public partial class DiskInShop
    {
        public int DiDDiskId { get; set; }
        public int? DiShopId { get; set; }
        public int? DiCost { get; set; }

        public virtual Diskk DiDDisk { get; set; } = null!;
        public virtual Shop? DiShop { get; set; }
    }
}
