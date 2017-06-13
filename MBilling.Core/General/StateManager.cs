using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.Core.General
{
    /// <summary>
    /// State enum specifies the different states of a module .
    /// The enum keyword is used to declare an enumeration, a distinct type that consists of a set of named constants called the enumerator list.
    /// </summary>
    public enum State
    {
        Unchanged,
        Added,
        Modified,
        Deleted
    }
    /// <summary>
    /// IObjectWithState interface defines State of type enum State
    /// An interface contains definitions for a group of related functionalities that a class or a struct can implement.
    /// </summary>
    public interface IObjectWithState
    {
        State State { get; set; }
    }

    public interface IObjectWithStateForEntity : IObjectWithState
    {
        int CreatedByUserId { get; set; }
        int ModifiedByUserId { get; set; }
    }

    public interface IObjectWithStateForTable : IObjectWithState
    {
        int Create_Usr { get; set; }
        int Modify_Usr { get; set; }
    }

    public interface IObjectWithBoolDelete : IObjectWithStateForTable
    {
        bool Delete_Ind { get; set; }
    }

    public interface IObjectWithIntDelete : IObjectWithStateForTable
    {
        int Delete_Ind { get; set; }
    }

    public interface IiPadEntity_CancelUpdateOnSpecifiedColumns
    {
        string[] ReadOnlyColumns { get; }
    }
}
