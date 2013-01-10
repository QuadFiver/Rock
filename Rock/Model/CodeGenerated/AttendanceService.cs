//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//

using System;
using System.Linq;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// Attendance Service class
    /// </summary>
    public partial class AttendanceService : Service<Attendance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttendanceService"/> class
        /// </summary>
        public AttendanceService()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttendanceService"/> class
        /// </summary>
        public AttendanceService(IRepository<Attendance> repository) : base(repository)
        {
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( Attendance item, out string errorMessage )
        {
            errorMessage = string.Empty;
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static class AttendanceExtensionMethods
    {
        /// <summary>
        /// Clones this Attendance object to a new Attendance object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static Attendance Clone( this Attendance source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as Attendance;
            }
            else
            {
                var target = new Attendance();
                target.LocationId = source.LocationId;
                target.ScheduleId = source.ScheduleId;
                target.GroupId = source.GroupId;
                target.PersonId = source.PersonId;
                target.QualifierValueId = source.QualifierValueId;
                target.StartDateTime = source.StartDateTime;
                target.EndDateTime = source.EndDateTime;
                target.DidAttend = source.DidAttend;
                target.SecurityCode = source.SecurityCode;
                target.Note = source.Note;
                target.Id = source.Id;
                target.Guid = source.Guid;

            
                return target;
            }
        }
    }
}
