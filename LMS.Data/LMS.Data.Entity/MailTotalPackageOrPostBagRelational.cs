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
    
    public partial class MailTotalPackageOrPostBagRelational : Entity
    {
        public virtual int ID { get; set; }
        public virtual string PostBagNumber { get; set; }
        public virtual string MailTotalPackageNumber { get; set; }
        public virtual System.DateTime ScanTime { get; set; }
        public virtual System.DateTime CreatedOn { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual System.DateTime LastUpdatedOn { get; set; }
        public virtual string LastUpdatedBy { get; set; }
    
        public virtual MailTotalPackageInfo MailTotalPackageInfo { get; set; }
        public virtual MailPostBagInfo MailPostBagInfo { get; set; }
    }
}
