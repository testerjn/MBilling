namespace MBilling.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class  StateProvince
    {
        [Key]
        public int StateId { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
    }
}
