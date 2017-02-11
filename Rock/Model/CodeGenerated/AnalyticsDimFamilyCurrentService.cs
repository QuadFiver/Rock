//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Linq;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// AnalyticsDimFamilyCurrent Service class
    /// </summary>
    public partial class AnalyticsDimFamilyCurrentService : Service<AnalyticsDimFamilyCurrent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsDimFamilyCurrentService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public AnalyticsDimFamilyCurrentService(RockContext context) : base(context)
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
        public bool CanDelete( AnalyticsDimFamilyCurrent item, out string errorMessage )
        {
            errorMessage = string.Empty;
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class AnalyticsDimFamilyCurrentExtensionMethods
    {
        /// <summary>
        /// Clones this AnalyticsDimFamilyCurrent object to a new AnalyticsDimFamilyCurrent object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static AnalyticsDimFamilyCurrent Clone( this AnalyticsDimFamilyCurrent source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as AnalyticsDimFamilyCurrent;
            }
            else
            {
                var target = new AnalyticsDimFamilyCurrent();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Copies the properties from another AnalyticsDimFamilyCurrent object to this AnalyticsDimFamilyCurrent object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this AnalyticsDimFamilyCurrent target, AnalyticsDimFamilyCurrent source )
        {
            target.Id = source.Id;
            target.AdultCount = source.AdultCount;
            target.CampusId = source.CampusId;
            target.CampusName = source.CampusName;
            target.CampusShortCode = source.CampusShortCode;
            target.ChildCount = source.ChildCount;
            target.ConnectionStatus = source.ConnectionStatus;
            target.CurrentRowIndicator = source.CurrentRowIndicator;
            target.EffectiveDate = source.EffectiveDate;
            target.ExpireDate = source.ExpireDate;
            target.FamilyId = source.FamilyId;
            target.FamilyTitle = source.FamilyTitle;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.HeadOfHouseholdPersonKey = source.HeadOfHouseholdPersonKey;
            target.IsEra = source.IsEra;
            target.IsFamilyActive = source.IsFamilyActive;
            target.MailingAddressCity = source.MailingAddressCity;
            target.MailingAddressCountry = source.MailingAddressCountry;
            target.MailingAddressCounty = source.MailingAddressCounty;
            target.MailingAddressGeoFence = source.MailingAddressGeoFence;
            target.MailingAddressGeoPoint = source.MailingAddressGeoPoint;
            target.MailingAddressLatitude = source.MailingAddressLatitude;
            target.MailingAddressLocationId = source.MailingAddressLocationId;
            target.MailingAddressLongitude = source.MailingAddressLongitude;
            target.MailingAddressPostalCode = source.MailingAddressPostalCode;
            target.MailingAddressState = source.MailingAddressState;
            target.MailingAddressStreet1 = source.MailingAddressStreet1;
            target.MailingAddressStreet2 = source.MailingAddressStreet2;
            target.MappedAddressCity = source.MappedAddressCity;
            target.MappedAddressCountry = source.MappedAddressCountry;
            target.MappedAddressCounty = source.MappedAddressCounty;
            target.MappedAddressGeoFence = source.MappedAddressGeoFence;
            target.MappedAddressGeoPoint = source.MappedAddressGeoPoint;
            target.MappedAddressLatitude = source.MappedAddressLatitude;
            target.MappedAddressLocationId = source.MappedAddressLocationId;
            target.MappedAddressLongitude = source.MappedAddressLongitude;
            target.MappedAddressPostalCode = source.MappedAddressPostalCode;
            target.MappedAddressState = source.MappedAddressState;
            target.MappedAddressStreet1 = source.MappedAddressStreet1;
            target.MappedAddressStreet2 = source.MappedAddressStreet2;
            target.Name = source.Name;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }
    }
}
