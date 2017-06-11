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
    public abstract class ViewModel<M> : IViewModel<M> where M : class
    {
        public ViewModel(M model) { Model = model; }

        public virtual M Model
        {
            get { return model; }
            set { setModel(value); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void RaisePropertyChangedFor(Expression<Func<M, object>> propertyExpression)
        //{
        //    MemberExpression expression = propertyExpression.Body as MemberExpression;
        //    if (expression == null)
        //            return;
        //    RaisePropertyChangedFor(expression.Member.Name);
        //}

        private void setModel(M value)
        {
            if (value == null) throw new ArgumentNullException("Model");
            model = value;
            //raisePropertyChangedFor("Model");
        }

        private M model;
    }
}
