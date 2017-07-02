using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Business.Business
{
    public static class ObjectExtensions
    {

        public static T ResolveViewModel<T>(this object value)
        {
            Type t = typeof(T);

            // Get the type that was made nullable.
            Type valueType = Nullable.GetUnderlyingType(typeof(T));

            if (valueType != null)
            {
                // Nullable type.

                if (value == null)
                {
                    // you may want to do something different here.
                    return default(T);
                }
                else
                {
                    // Convert to the value type.
                    object result = Convert.ChangeType(value, valueType);

                    // Cast the value type to the nullable type.
                    return (T)result;
                }
            }
            else
            {
                // Not nullable.
                return (T)Convert.ChangeType(value, typeof(T));
            }
        }


        private static T ResolveViewModelArray(this object value)
        {
            foreach (TaxRate taxRateEntity in value)
            {
                yield return new TaxRateViewModel(taxRateEntity);
            }
        }
    }
}
