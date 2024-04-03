using System;
using System.Collections.Generic;

namespace EF.Models
{
    public partial class Shop
    {
        public Shop()
        {
            DiskInShops = new HashSet<DiskInShop>();
        }

        public int SShopId { get; set; }
        public string? SShopName { get; set; }

        public virtual ICollection<DiskInShop> DiskInShops { get; set; }
    }
}
