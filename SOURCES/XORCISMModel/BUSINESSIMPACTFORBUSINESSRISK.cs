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
    
    public partial class BUSINESSIMPACTFORBUSINESSRISK
    {
        public int BusinessRiskBusinessImpactID { get; set; }
        public int BusinessImpactID { get; set; }
        public string BusinessImpactGUID { get; set; }
        public int BusinessRiskID { get; set; }
        public string BusinessRiskGUID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual BUSINESSIMPACT BUSINESSIMPACT { get; set; }
        public virtual BUSINESSRISK BUSINESSRISK { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}
