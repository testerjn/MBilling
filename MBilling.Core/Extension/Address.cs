using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Core
{
    public partial class Address : IDataErrorInfo
    {
        #region IDataErrorInfo Members

        public string this[string ColumnName]
        {
            get
            {

                string result = null;

                if (ColumnName == "DisplayName")
                {
                    /// <summary>
                    /// Columname(DisplayName) is null or empty
                    /// </Summary>
                    if (string.IsNullOrEmpty(Address1))
                    {
                        result = "Please enter address desciption";
                    }
                    /// <summary>
                    /// Columname(DisplayName) length should not be greater than 50 characters.
                    /// </Summary>
                    else if (Address1.Length > 50)
                    {
                        result = "Length should not be greater than 50";
                    }
                }
                //if (ColumnName == "AlertDescription")
                //{

                //    /// <summary>
                //    /// Columname(AlertDescription) length should not be greater than 255 characters.
                //    /// </Summary>
                //    if (!string.IsNullOrEmpty(AlertDescription) && AlertDescription.Length > 255)
                //    {
                //        result = "Alert Description length should not be greater than 255 characters";
                //    }

                //}

                //if (ColumnName == "Category")
                //{
                //    /// <summary>
                //    /// Columname(Category) is null or empty
                //    /// </Summary>
                //    if (Category == null)
                //    {
                //        result = "Please select Category";
                //    }
                //    if (Category == Guid.Empty)
                //    {
                //        result = "Please select Category";
                //    }
                //}

                //if (ColumnName == "Priority")
                //{
                //    /// <summary>
                //    /// Columname(Priority) is null or empty
                //    /// </Summary>
                //    if (string.IsNullOrEmpty(Priority.ToString()))
                //    {
                //        result = "Please select priority";
                //    }
                //    if (Priority == Guid.Empty)
                //    {
                //        result = "Please select priority";
                //    }
                //}
                return result;
            }

        }
        /// <exception cref="T:System.NotImplementedException">
        /// <return>
        /// Error
        /// </return>
        /// </exception>
        public string Error
        {

            get { throw new NotImplementedException(); }
        }
        #endregion
    }
}
