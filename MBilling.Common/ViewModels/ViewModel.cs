using MBilling.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Common.ViewModels
{
    public abstract class ViewModel<TEntity> : INotifyPropertyChanged where TEntity : class 
    {
        protected ViewModel(TEntity model)
        {
            if (model == null) throw new ArgumentNullException("model");
            this.model = model;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public TEntity Model { get { return model; } set { setNonNullModel(value); } }

        protected virtual void RaisePropertyChangedFor(
            Expression<Func<TEntity, object>> propertyExpression)
        {
            var propertyName = propertyExpression.GetType().Name;
            RaisePropertyChangedFor(propertyName);
        }

        protected void RaisePropertyChangedFor(string propertyName)
        {
            if (propertyName == null)
            {
                throw new ArgumentNullException("propertyName");
            }

            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void setNonNullModel(TEntity value)
        {
            if (value != null)
            {
                model = value;
                RaisePropertyChangedFor("Model");
            }
        }

        private TEntity model;

    }
}
