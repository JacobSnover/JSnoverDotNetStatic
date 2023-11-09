using System;
using System.Collections.Generic;

namespace JSnoverDotNetStatic.Models
{
    public partial class Subscribers
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime SubscribeDate { get; set; }
    }
}
