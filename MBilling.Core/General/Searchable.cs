using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Core.General
{
    /// <summary>
    /// Searchable class specifies wether a particular property is searchable or not
    /// Searchable class implements the Attribute which is the base class for custom attributes
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class Searchable : Attribute
    {
    }
}
