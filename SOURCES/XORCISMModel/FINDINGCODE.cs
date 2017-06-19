//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XORCISMModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class FINDINGCODE
    {
        public int FindingCodeID { get; set; }
        public int FindingID { get; set; }
        public int CodeID { get; set; }
        public Nullable<int> CodeLineID { get; set; }
        public string FindingCodeDescription { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public Nullable<int> ConfidenceReasonID { get; set; }
        public Nullable<int> ImportanceID { get; set; }
        public Nullable<int> CriticalityLevelID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual CODE CODE { get; set; }
        public virtual CODELINE CODELINE { get; set; }
        public virtual CONFIDENCELEVEL CONFIDENCELEVEL { get; set; }
        public virtual CONFIDENCEREASON CONFIDENCEREASON { get; set; }
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        public virtual CRITICALITYLEVEL CRITICALITYLEVEL { get; set; }
        public virtual FINDING FINDING { get; set; }
        public virtual IMPORTANCE IMPORTANCE { get; set; }
    }
}