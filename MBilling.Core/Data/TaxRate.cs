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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.CompilerServices;

    public partial class TaxRate : INotifyPropertyChanged, IObjectWithStateForEntity, ICloneable
    {
        internal int _TaxRateId;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaxRateId {
            get
            {
                return _TaxRateId;
            }
            set
            {
                _TaxRateId = value;
                OnPropertyChanged("TaxRateId");
            }
        }

        internal int _StateProvinceId;
        [Display(Name = "State Name")]
        [Searchable]
        [Required(ErrorMessage = "State name is required")]
        public int StateProvinceId
        {
            get
            {
                return _StateProvinceId;
            }
            set
            {
                _StateProvinceId = value;
                OnPropertyChanged("StateProvinceId");
            }
        }
        internal byte _TaxType;
        [Display(Name = "Tax Type")]
        [Searchable]
        [Required(ErrorMessage = "Tax type {0} is required")]
        public byte TaxType
        {
            get
            {
                return _TaxType;
            }
            set
            {
                _TaxType = value;
                OnPropertyChanged("TaxType");
            }
        }

        internal decimal _TaxRate1;
        [Display(Name = "Tax Rate")]
        [Column(name: "TaxRate")]
        [Required(ErrorMessage = "Tax rate is required")]
        public decimal TaxRate1
        {
            get
            {
                return _TaxRate1;
            }
            set
            {
                _TaxRate1 = value;
                OnPropertyChanged("TaxRate");
            }
        }

        internal string _TaxName;
        [Display(Name = "Tax Name")]
        [Required(ErrorMessage = "Tax name is required")]
        [Searchable]
        public string TaxName
        {
            get
            {
                return _TaxName;
            }
            set
            {
                _TaxName = value;
                OnPropertyChanged("TaxName");
            }
        }

        internal DateTime _ApplyDate;
        [Display(Name = "Apply Date")]
        [Required(ErrorMessage = "Date of tax applied {0} is required")]
        [Searchable]
        public System.DateTime ApplyDate
        {
            get
            {
                return _ApplyDate;
            }
            set
            {
                _ApplyDate = value;
                OnPropertyChanged("ApplyDate");
            }
        }

        internal Nullable<bool> _IsActive = true;
        public Nullable<bool> IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                _IsActive = value;
                OnPropertyChanged("IsActive");
            }
        }

        internal int _CreatedByUserId;
        public int CreatedByUserId
        {
            get
            {
                return _CreatedByUserId;
            }
            set
            {
                _CreatedByUserId = value;
                OnPropertyChanged("CreatedByUserId");
            }
        }

        internal int _ModifiedByUserId;
        public int ModifiedByUserId
        {
            get
            {
                return _ModifiedByUserId;
            }
            set
            {
                _ModifiedByUserId = value;
                OnPropertyChanged("ModifiedByUserId");
            }
        }

        internal State _state;
        [NotMapped]
        public State State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
                OnPropertyChanged("State");
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
                if (this.State == State.Unchanged)
                {
                    if (this.TaxRateId == 0)
                    {
                        this.State = State.Added;
                    }
                    else
                        this.State = State.Modified;
                }

            }
        }

    }
}
