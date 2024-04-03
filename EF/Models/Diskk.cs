using System;
using System.Collections.Generic;

namespace EF.Models
{
    public partial class Diskk
    {
        public int DiDiskId { get; set; }
        public string? DiDiskName { get; set; }

        public virtual DiskInShop? DiskInShop { get; set; }
    }
}
