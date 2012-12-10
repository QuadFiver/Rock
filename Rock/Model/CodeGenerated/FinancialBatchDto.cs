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
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// Data Transfer Object for FinancialBatch object
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class FinancialBatchDto : DtoSecured<FinancialBatchDto>
    {
        /// <summary />
        [DataMember]
        public string Name { get; set; }

        /// <summary />
        [DataMember]
        public DateTime? BatchDate { get; set; }

        /// <summary />
        [DataMember]
        public bool IsClosed { get; set; }

        /// <summary />
        [DataMember]
        public int? CampusId { get; set; }

        /// <summary />
        [DataMember]
        public string Entity { get; set; }

        /// <summary />
        [DataMember]
        public int? EntityId { get; set; }

        /// <summary />
        [DataMember]
        public string ForeignReference { get; set; }

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public FinancialBatchDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="financialBatch"></param>
        public FinancialBatchDto ( FinancialBatch financialBatch )
        {
            CopyFromModel( financialBatch );
        }

        /// <summary>
        /// Creates a dictionary object.
        /// </summary>
        /// <returns></returns>
        public override Dictionary<string, object> ToDictionary()
        {
            var dictionary = base.ToDictionary();
            dictionary.Add( "Name", this.Name );
            dictionary.Add( "BatchDate", this.BatchDate );
            dictionary.Add( "IsClosed", this.IsClosed );
            dictionary.Add( "CampusId", this.CampusId );
            dictionary.Add( "Entity", this.Entity );
            dictionary.Add( "EntityId", this.EntityId );
            dictionary.Add( "ForeignReference", this.ForeignReference );
            return dictionary;
        }

        /// <summary>
        /// Creates a dynamic object.
        /// </summary>
        /// <returns></returns>
        public override dynamic ToDynamic()
        {
            dynamic expando = base.ToDynamic();
            expando.Name = this.Name;
            expando.BatchDate = this.BatchDate;
            expando.IsClosed = this.IsClosed;
            expando.CampusId = this.CampusId;
            expando.Entity = this.Entity;
            expando.EntityId = this.EntityId;
            expando.ForeignReference = this.ForeignReference;
            return expando;
        }

        /// <summary>
        /// Copies the model property values to the DTO properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyFromModel( IEntity model )
        {
            base.CopyFromModel( model );

            if ( model is FinancialBatch )
            {
                var financialBatch = (FinancialBatch)model;
                this.Name = financialBatch.Name;
                this.BatchDate = financialBatch.BatchDate;
                this.IsClosed = financialBatch.IsClosed;
                this.CampusId = financialBatch.CampusId;
                this.Entity = financialBatch.Entity;
                this.EntityId = financialBatch.EntityId;
                this.ForeignReference = financialBatch.ForeignReference;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyToModel ( IEntity model )
        {
            base.CopyToModel( model );

            if ( model is FinancialBatch )
            {
                var financialBatch = (FinancialBatch)model;
                financialBatch.Name = this.Name;
                financialBatch.BatchDate = this.BatchDate;
                financialBatch.IsClosed = this.IsClosed;
                financialBatch.CampusId = this.CampusId;
                financialBatch.Entity = this.Entity;
                financialBatch.EntityId = this.EntityId;
                financialBatch.ForeignReference = this.ForeignReference;
            }
        }

    }


    /// <summary>
    /// FinancialBatch Extension Methods
    /// </summary>
    public static class FinancialBatchExtensions
    {
        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static FinancialBatch ToModel( this FinancialBatchDto value )
        {
            FinancialBatch result = new FinancialBatch();
            value.CopyToModel( result );
            return result;
        }

        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<FinancialBatch> ToModel( this List<FinancialBatchDto> value )
        {
            List<FinancialBatch> result = new List<FinancialBatch>();
            value.ForEach( a => result.Add( a.ToModel() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<FinancialBatchDto> ToDto( this List<FinancialBatch> value )
        {
            List<FinancialBatchDto> result = new List<FinancialBatchDto>();
            value.ForEach( a => result.Add( a.ToDto() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static FinancialBatchDto ToDto( this FinancialBatch value )
        {
            return new FinancialBatchDto( value );
        }

        /// <summary>
        /// To the json.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        /// <returns></returns>
        public static string ToJson( this FinancialBatch value, bool deep = false )
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject( ToDynamic( value, deep ) );
        }

        /// <summary>
        /// To the dynamic.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public static List<dynamic> ToDynamic( this ICollection<FinancialBatch> values )
        {
            var dynamicList = new List<dynamic>();
            foreach ( var value in values )
            {
                dynamicList.Add( value.ToDynamic( true ) );
            }
            return dynamicList;
        }

        /// <summary>
        /// To the dynamic.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        /// <returns></returns>
        public static dynamic ToDynamic( this FinancialBatch value, bool deep = false )
        {
            dynamic dynamicFinancialBatch = new FinancialBatchDto( value ).ToDynamic();

            if ( !deep )
            {
                return dynamicFinancialBatch;
            }


            if (value.Transactions != null)
            {
                dynamicFinancialBatch.Transactions = value.Transactions.ToDynamic();
            }

            return dynamicFinancialBatch;
        }

        /// <summary>
        /// Froms the json.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="json">The json.</param>
        public static void FromJson( this FinancialBatch value, string json )
        {
            //Newtonsoft.Json.JsonConvert.PopulateObject( json, value );
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject( json, typeof( ExpandoObject ) );
            value.FromDynamic( obj, true );
        }

        /// <summary>
        /// Froms the dynamic.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="obj">The obj.</param>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        public static void FromDynamic( this FinancialBatch value, object obj, bool deep = false )
        {
            new PageDto().FromDynamic(obj).CopyToModel(value);

            if (deep)
            {
                var expando = obj as ExpandoObject;
                if (obj != null)
                {
                    var dict = obj as IDictionary<string, object>;
                    if (dict != null)
                    {

                        // Transactions
                        if (dict.ContainsKey("Transactions"))
                        {
                            var TransactionsList = dict["Transactions"] as List<object>;
                            if (TransactionsList != null)
                            {
                                value.Transactions = new List<FinancialTransaction>();
                                foreach(object childObj in TransactionsList)
                                {
                                    var FinancialTransaction = new FinancialTransaction();
                                    new FinancialTransactionDto().FromDynamic(childObj).CopyToModel(FinancialTransaction);
                                    value.Transactions.Add(FinancialTransaction);
                                }
                            }
                        }

                    }
                }
            }
        }

    }
}