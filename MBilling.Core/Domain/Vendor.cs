namespace MBilling.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using MBilling.Core;
    using System.ComponentModel.DataAnnotations.Schema;

    [NotMapped]
    public partial class Vendor : Person
    {

        public Vendor()
        {
            this.PersonTypeId = PersonTypeEnum.Vendor;
        }

    }
}
