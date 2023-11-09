using System;
using System.Collections.Generic;

namespace JSnoverDotNetStatic.Models
{
    public partial class Photos
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
