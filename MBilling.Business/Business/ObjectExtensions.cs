using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Business.Business
{

    //static class ListCast<TSource, TResult, TItemType> where TSource : IEnumerable<TItemType>
    //                                                    where TResult : IList<TItemType>, new()
    //{
    //    static TResult Cast(TSource list)
    //    {
    //        TResult castedList = new TResult();
    //        foreach (TItemType item in list)
    //        {
    //            castedList.Add(TItemType)item);
    //        }

    //        return castedList;
    //    }
    //}



    //public static class ObjectExtensions<TSource, TResult>
    //{


    //    public static TResult ResolveViewModel(TSource Input)
    //    {
    //        //TResult result = new TResult();

    //        if (Input is IEnumerable)
    //        {
    //            return ((IEnumerable)Input).Cast<TResult>().ToList();
    //        }
    //        //return result;
    //    }
    //}

    ////    public static T ResolveViewModel<T>(this object value)
    ////    {
    ////        Type t = typeof(T);

    ////        // Get the type that was made nullable.
    ////        Type valueType = Nullable.GetUnderlyingType(typeof(T));

    ////        if (valueType != null)
    ////        {
    ////            // Nullable type.

    ////            if (value == null)
    ////            {
    ////                // you may want to do something different here.
    ////                return default(T);
    ////            }
    ////            else
    ////            {
    ////                // Convert to the value type.
    ////                object result = Convert.ChangeType(value, valueType);

    ////                // Cast the value type to the nullable type.
    ////                return (T)result;
    ////            }
    ////        }
    ////        else
    ////        {
    ////            // Not nullable.
    ////            return (T)Convert.ChangeType(value, typeof(T));
    ////        }
    ////    }


    ////    private static T ResolveViewModelArray<T>(this object Input)
    ////    {
    ////        if (Input is IEnumerable)
    ////        {
    ////            return ((IEnumerable)Input).Cast<T>().ToList();
    ////        }
    ////        else
    ////        {
    ////            return new List<T>() { (T)Input };  


    ////        }
    ////        foreach (object item in value)
    ////        {
    ////            yield return new T(item);
    ////        }
    ////    }
    ////}
}
