using System;
using System.Collections.Generic;

namespace JSnoverDotNetStatic.Models
{
    public partial class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
