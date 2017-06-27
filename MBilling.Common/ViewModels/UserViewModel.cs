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
    public class UserViewModel : ViewModel<User>
    {
        private readonly User m_UserData;

        public UserViewModel(User _User)
            : base(_User)
        {
            m_UserData = _User;
        }

        public int PersonId
        {
            get { return m_UserData.PersonId; }
            set { m_UserData.PersonId = value; }
        }


        [Display(Name = "User Name")]
        [Column(name: "Name")]
        [Required(ErrorMessage = "User Name is required")]
        public string Name
        {
            get { return m_UserData.Name; }
            set { m_UserData.Name = value; }
        }
    }
}
