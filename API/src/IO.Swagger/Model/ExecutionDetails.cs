/* 
 * FIXServer - API
 *
 * Open API for FIXServer integrations.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// ExecutionDetails
    /// </summary>
    [DataContract]
        public partial class ExecutionDetails :  IEquatable<ExecutionDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionDetails" /> class.
        /// </summary>
        /// <param name="executionReportId">executionReportId.</param>
        /// <param name="newOrderSingleId">newOrderSingleId.</param>
        /// <param name="instance">instance.</param>
        /// <param name="sessionName">sessionName.</param>
        /// <param name="externalId">externalId.</param>
        /// <param name="symbol">symbol.</param>
        /// <param name="side">side.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="clOrdId">clOrdId.</param>
        /// <param name="execId">execId.</param>
        /// <param name="fixMessage">fixMessage.</param>
        /// <param name="lastQty">lastQty.</param>
        /// <param name="lastPx">lastPx.</param>
        /// <param name="cumQty">cumQty.</param>
        /// <param name="avgPx">avgPx.</param>
        /// <param name="qtyRemaining">qtyRemaining.</param>
        /// <param name="createdDate">createdDate.</param>
        public ExecutionDetails(int? executionReportId = default(int?), int? newOrderSingleId = default(int?), string instance = default(string), string sessionName = default(string), string externalId = default(string), string symbol = default(string), string side = default(string), double? quantity = default(double?), string clOrdId = default(string), string execId = default(string), string fixMessage = default(string), double? lastQty = default(double?), double? lastPx = default(double?), double? cumQty = default(double?), double? avgPx = default(double?), double? qtyRemaining = default(double?), DateTime? createdDate = default(DateTime?))
        {
            this.ExecutionReportId = executionReportId;
            this.NewOrderSingleId = newOrderSingleId;
            this.Instance = instance;
            this.SessionName = sessionName;
            this.ExternalId = externalId;
            this.Symbol = symbol;
            this.Side = side;
            this.Quantity = quantity;
            this.ClOrdId = clOrdId;
            this.ExecId = execId;
            this.FixMessage = fixMessage;
            this.LastQty = lastQty;
            this.LastPx = lastPx;
            this.CumQty = cumQty;
            this.AvgPx = avgPx;
            this.QtyRemaining = qtyRemaining;
            this.CreatedDate = createdDate;
        }
        
        /// <summary>
        /// Gets or Sets ExecutionReportId
        /// </summary>
        [DataMember(Name="executionReportId", EmitDefaultValue=false)]
        public int? ExecutionReportId { get; set; }

        /// <summary>
        /// Gets or Sets NewOrderSingleId
        /// </summary>
        [DataMember(Name="newOrderSingleId", EmitDefaultValue=false)]
        public int? NewOrderSingleId { get; set; }

        /// <summary>
        /// Gets or Sets Instance
        /// </summary>
        [DataMember(Name="instance", EmitDefaultValue=false)]
        public string Instance { get; set; }

        /// <summary>
        /// Gets or Sets SessionName
        /// </summary>
        [DataMember(Name="sessionName", EmitDefaultValue=false)]
        public string SessionName { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets Side
        /// </summary>
        [DataMember(Name="side", EmitDefaultValue=false)]
        public string Side { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public double? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets ClOrdId
        /// </summary>
        [DataMember(Name="clOrdId", EmitDefaultValue=false)]
        public string ClOrdId { get; set; }

        /// <summary>
        /// Gets or Sets ExecId
        /// </summary>
        [DataMember(Name="execId", EmitDefaultValue=false)]
        public string ExecId { get; set; }

        /// <summary>
        /// Gets or Sets FixMessage
        /// </summary>
        [DataMember(Name="fixMessage", EmitDefaultValue=false)]
        public string FixMessage { get; set; }

        /// <summary>
        /// Gets or Sets LastQty
        /// </summary>
        [DataMember(Name="lastQty", EmitDefaultValue=false)]
        public double? LastQty { get; set; }

        /// <summary>
        /// Gets or Sets LastPx
        /// </summary>
        [DataMember(Name="lastPx", EmitDefaultValue=false)]
        public double? LastPx { get; set; }

        /// <summary>
        /// Gets or Sets CumQty
        /// </summary>
        [DataMember(Name="cumQty", EmitDefaultValue=false)]
        public double? CumQty { get; set; }

        /// <summary>
        /// Gets or Sets AvgPx
        /// </summary>
        [DataMember(Name="avgPx", EmitDefaultValue=false)]
        public double? AvgPx { get; set; }

        /// <summary>
        /// Gets or Sets QtyRemaining
        /// </summary>
        [DataMember(Name="qtyRemaining", EmitDefaultValue=false)]
        public double? QtyRemaining { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutionDetails {\n");
            sb.Append("  ExecutionReportId: ").Append(ExecutionReportId).Append("\n");
            sb.Append("  NewOrderSingleId: ").Append(NewOrderSingleId).Append("\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
            sb.Append("  SessionName: ").Append(SessionName).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ClOrdId: ").Append(ClOrdId).Append("\n");
            sb.Append("  ExecId: ").Append(ExecId).Append("\n");
            sb.Append("  FixMessage: ").Append(FixMessage).Append("\n");
            sb.Append("  LastQty: ").Append(LastQty).Append("\n");
            sb.Append("  LastPx: ").Append(LastPx).Append("\n");
            sb.Append("  CumQty: ").Append(CumQty).Append("\n");
            sb.Append("  AvgPx: ").Append(AvgPx).Append("\n");
            sb.Append("  QtyRemaining: ").Append(QtyRemaining).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecutionDetails);
        }

        /// <summary>
        /// Returns true if ExecutionDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ExecutionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecutionDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExecutionReportId == input.ExecutionReportId ||
                    (this.ExecutionReportId != null &&
                    this.ExecutionReportId.Equals(input.ExecutionReportId))
                ) && 
                (
                    this.NewOrderSingleId == input.NewOrderSingleId ||
                    (this.NewOrderSingleId != null &&
                    this.NewOrderSingleId.Equals(input.NewOrderSingleId))
                ) && 
                (
                    this.Instance == input.Instance ||
                    (this.Instance != null &&
                    this.Instance.Equals(input.Instance))
                ) && 
                (
                    this.SessionName == input.SessionName ||
                    (this.SessionName != null &&
                    this.SessionName.Equals(input.SessionName))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.ClOrdId == input.ClOrdId ||
                    (this.ClOrdId != null &&
                    this.ClOrdId.Equals(input.ClOrdId))
                ) && 
                (
                    this.ExecId == input.ExecId ||
                    (this.ExecId != null &&
                    this.ExecId.Equals(input.ExecId))
                ) && 
                (
                    this.FixMessage == input.FixMessage ||
                    (this.FixMessage != null &&
                    this.FixMessage.Equals(input.FixMessage))
                ) && 
                (
                    this.LastQty == input.LastQty ||
                    (this.LastQty != null &&
                    this.LastQty.Equals(input.LastQty))
                ) && 
                (
                    this.LastPx == input.LastPx ||
                    (this.LastPx != null &&
                    this.LastPx.Equals(input.LastPx))
                ) && 
                (
                    this.CumQty == input.CumQty ||
                    (this.CumQty != null &&
                    this.CumQty.Equals(input.CumQty))
                ) && 
                (
                    this.AvgPx == input.AvgPx ||
                    (this.AvgPx != null &&
                    this.AvgPx.Equals(input.AvgPx))
                ) && 
                (
                    this.QtyRemaining == input.QtyRemaining ||
                    (this.QtyRemaining != null &&
                    this.QtyRemaining.Equals(input.QtyRemaining))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ExecutionReportId != null)
                    hashCode = hashCode * 59 + this.ExecutionReportId.GetHashCode();
                if (this.NewOrderSingleId != null)
                    hashCode = hashCode * 59 + this.NewOrderSingleId.GetHashCode();
                if (this.Instance != null)
                    hashCode = hashCode * 59 + this.Instance.GetHashCode();
                if (this.SessionName != null)
                    hashCode = hashCode * 59 + this.SessionName.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.ClOrdId != null)
                    hashCode = hashCode * 59 + this.ClOrdId.GetHashCode();
                if (this.ExecId != null)
                    hashCode = hashCode * 59 + this.ExecId.GetHashCode();
                if (this.FixMessage != null)
                    hashCode = hashCode * 59 + this.FixMessage.GetHashCode();
                if (this.LastQty != null)
                    hashCode = hashCode * 59 + this.LastQty.GetHashCode();
                if (this.LastPx != null)
                    hashCode = hashCode * 59 + this.LastPx.GetHashCode();
                if (this.CumQty != null)
                    hashCode = hashCode * 59 + this.CumQty.GetHashCode();
                if (this.AvgPx != null)
                    hashCode = hashCode * 59 + this.AvgPx.GetHashCode();
                if (this.QtyRemaining != null)
                    hashCode = hashCode * 59 + this.QtyRemaining.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
