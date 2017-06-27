using MBilling.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Common.ViewModels
{
    public class VendorViewModel : ViewModel<Vendor>
    {
        private readonly Vendor m_VendorData;

        public VendorViewModel(Vendor _Vendor)
            : base(_Vendor)
        {
            m_VendorData = _Vendor;
        }

        public int PersonId
        {
            get { return m_VendorData.PersonId; }
            set { m_VendorData.PersonId = value; }
        }


        [Display(Name = "Vendor Name")]
        [Column(name: "Name")]
        [Required(ErrorMessage = "Vendor Name is required")]
        public string Name
        {
            get { return m_VendorData.Name; }
            set { m_VendorData.Name = value; }
        }
    }
}
