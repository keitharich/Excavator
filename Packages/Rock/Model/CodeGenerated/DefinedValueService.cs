//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright 2013 by the Spark Development Network
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
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
    /// DefinedValue Service class
    /// </summary>
    public partial class DefinedValueService : Service<DefinedValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefinedValueService"/> class
        /// </summary>
        public DefinedValueService()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefinedValueService"/> class
        /// </summary>
        /// <param name="repository">The repository.</param>
        public DefinedValueService(IRepository<DefinedValue> repository) : base(repository)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefinedValueService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public DefinedValueService(RockContext context) : base(context)
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
        public bool CanDelete( DefinedValue item, out string errorMessage )
        {
            errorMessage = string.Empty;
            
            // ignoring Attendance,QualifierValueId 
            
            // ignoring Attendance,SearchTypeValueId 
 
            if ( new Service<Device>().Queryable().Any( a => a.DeviceTypeValueId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", DefinedValue.FriendlyTypeName, Device.FriendlyTypeName );
                return false;
            }  
 
            if ( new Service<FinancialAccount>().Queryable().Any( a => a.AccountTypeValueId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", DefinedValue.FriendlyTypeName, FinancialAccount.FriendlyTypeName );
                return false;
            }  
            
            // ignoring FinancialPersonSavedAccount,CreditCardTypeValueId 
            
            // ignoring FinancialPersonSavedAccount,CurrencyTypeValueId 
 
            if ( new Service<FinancialPledge>().Queryable().Any( a => a.PledgeFrequencyValueId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", DefinedValue.FriendlyTypeName, FinancialPledge.FriendlyTypeName );
                return false;
            }  
 
            if ( new Service<FinancialScheduledTransaction>().Queryable().Any( a => a.TransactionFrequencyValueId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", DefinedValue.FriendlyTypeName, FinancialScheduledTransaction.FriendlyTypeName );
                return false;
            }  
            
            // ignoring FinancialTransaction,CreditCardTypeValueId 
            
            // ignoring FinancialTransaction,CurrencyTypeValueId 
            
            // ignoring FinancialTransaction,SourceTypeValueId 
            
            // ignoring FinancialTransaction,TransactionTypeValueId 
 
            if ( new Service<FinancialTransactionImage>().Queryable().Any( a => a.TransactionImageTypeValueId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", DefinedValue.FriendlyTypeName, FinancialTransactionImage.FriendlyTypeName );
                return false;
            }  
 
            if ( new Service<FinancialTransactionRefund>().Queryable().Any( a => a.RefundReasonValueId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", DefinedValue.FriendlyTypeName, FinancialTransactionRefund.FriendlyTypeName );
                return false;
            }  
            
            // ignoring GroupLocation,GroupLocationTypeValueId 
 
            if ( new Service<GroupType>().Queryable().Any( a => a.GroupTypePurposeValueId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", DefinedValue.FriendlyTypeName, GroupType.FriendlyTypeName );
                return false;
            }  
 
            if ( new Service<Metric>().Queryable().Any( a => a.CollectionFrequencyValueId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", DefinedValue.FriendlyTypeName, Metric.FriendlyTypeName );
                return false;
            }  
 
            if ( new Service<Note>().Queryable().Any( a => a.SourceTypeValueId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", DefinedValue.FriendlyTypeName, Note.FriendlyTypeName );
                return false;
            }  
            
            // ignoring Person,ConnectionStatusValueId 
            
            // ignoring Person,MaritalStatusValueId 
            
            // ignoring Person,RecordStatusReasonValueId 
            
            // ignoring Person,RecordStatusValueId 
            
            // ignoring Person,RecordTypeValueId 
            
            // ignoring Person,SuffixValueId 
            
            // ignoring Person,TitleValueId 
 
            if ( new Service<PhoneNumber>().Queryable().Any( a => a.NumberTypeValueId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", DefinedValue.FriendlyTypeName, PhoneNumber.FriendlyTypeName );
                return false;
            }  
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class DefinedValueExtensionMethods
    {
        /// <summary>
        /// Clones this DefinedValue object to a new DefinedValue object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static DefinedValue Clone( this DefinedValue source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as DefinedValue;
            }
            else
            {
                var target = new DefinedValue();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Copies the properties from another DefinedValue object to this DefinedValue object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this DefinedValue target, DefinedValue source )
        {
            target.IsSystem = source.IsSystem;
            target.DefinedTypeId = source.DefinedTypeId;
            target.Order = source.Order;
            target.Name = source.Name;
            target.Description = source.Description;
            target.CreatedDateTime = source.CreatedDateTime;
            target.ModifiedDateTime = source.ModifiedDateTime;
            target.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            target.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            target.Id = source.Id;
            target.Guid = source.Guid;

        }
    }
}
