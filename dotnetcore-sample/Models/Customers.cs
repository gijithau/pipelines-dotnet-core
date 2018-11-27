using System;
using System.Collections.Generic;

namespace dotnetcore_sample.Models
{
    public partial class Customers
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public string Status { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}
