//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Entity
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using LighTake.Infrastructure.Seedwork;
    
    public partial class WaybillPackageDetail : Entity
    {
        public virtual int PackageDetailID { get; set; }
        public virtual string WayBillNumber { get; set; }
        public virtual Nullable<decimal> Weight { get; set; }
        public virtual Nullable<decimal> SettleWeight { get; set; }
        public virtual Nullable<decimal> Length { get; set; }
        public virtual Nullable<decimal> Width { get; set; }
        public virtual Nullable<decimal> Height { get; set; }
        public virtual Nullable<decimal> LengthiFee { get; set; }
        public virtual Nullable<decimal> WeightFee { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual System.DateTime CreatedOn { get; set; }
        public virtual string LastUpdatedBy { get; set; }
        public virtual Nullable<System.DateTime> LastUpdatedOn { get; set; }
        public virtual Nullable<decimal> AddWeight { get; set; }
        public virtual Nullable<decimal> DeliverySettleWeight { get; set; }
    }
}