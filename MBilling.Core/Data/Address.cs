//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MBilling.Core
{
    using General;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public partial class Address : INotifyPropertyChanged, IObjectWithStateForEntity, ICloneable
    {
        
        public Address()
        {
            PersonAddresses = new HashSet<PersonAddress>();
        }

        [Key]
        public int AddressID { get; set; }

        internal string _Address1;
        [Display(Name = "Address1")]
        [Searchable]
        [Required (ErrorMessage="Address {0} is required")]
        public string Address1 
        { 
         get
            {
                return _Address1;
            }
            set
            {
                _Address1 = value;
                OnPropertyChanged("Address1");
            } 
        }
        
        internal string _Address2;
        [Display(Name = "Address2")]
        [Searchable]
        public string Address2 
        { 
         get
            {
                return _Address2;
            }
            set
            {
                _Address2 = value;
                OnPropertyChanged("Address2");
            } 
        }
        
        internal string _Address3;
        public string Address3 
        { 
         get
            {
                return _Address3;
            }
            set
            {
                _Address3 = value;
                OnPropertyChanged("Address3");
            } 
        }
        
        internal string _Town;
        [Display(Name = "City")]
        [Searchable]
        [Required (ErrorMessage="Enter city name")]
        public string Town 
        { 
         get
            {
                return _Town;
            }
            set
            {
                _Town = value;
                OnPropertyChanged("Town");
            } 
        }
        
        
        internal int _StateId;
        [Display(Name = "StateName")]
        [Searchable]
        public int StateId 
        { 
         get
            {
                return _StateId;
            }
            set
            {
                _StateId = value;
                OnPropertyChanged("StateId");
            } 
        }
        
        internal string _PostalCode;
        [Display(Name = "PostalCode")]
        [Searchable]
        [Required (ErrorMessage="Postal code {0} is required")]
        public string PostalCode   
        { 
         get
            {
                return _PostalCode;
            }
            set
            {
                _PostalCode = value;
                OnPropertyChanged("PostalCode");
            } 
        }

        internal int _CreatedByUser;
        public int CreatedByUserId
        {
            get
            {
                return _CreatedByUser;
            }
            set
            {
                _CreatedByUser = value;
                OnPropertyChanged("CreatedByUserId");
            }
        }

        internal int _ModifiedByUser;
        public int ModifiedByUserId
        {
            get
            {
                return _ModifiedByUser;
            }
            set
            {
                _ModifiedByUser = value;
                OnPropertyChanged("CreatedByUserId");
            }
        }

        public Nullable<System.DateTime> CrteatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }

        internal State _State;
        public State State
        {
            get { return _State; }
            set
            {
                _State = value;
                OnPropertyChanged("State");
            }
        }

        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
                if (this.State == State.Unchanged)
                {
                    if (this.AddressID == 0)
                    {
                        this.State = State.Added;
                    }
                    else
                        this.State = State.Modified;
                }

            }
        }

        public string SearchText
        {
            get
            {
                string _Temp = "";
                foreach (var prop in this.GetType().GetProperties().Where(A => A.GetCustomAttributes(typeof(Searchable), true).Length != 0))
                {
                    _Temp = _Temp + "|" + prop.GetValue(this, null);
                }
                return _Temp;
            }
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
