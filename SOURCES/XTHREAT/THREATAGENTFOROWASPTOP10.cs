//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XTHREATModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class THREATAGENTFOROWASPTOP10
    {
        public int OWASPTOP10ThreatAgentID { get; set; }
        public int OWASPTOP10ID { get; set; }
        public int ThreatAgentID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public Nullable<int> ConfidenceReasonID { get; set; }
        public Nullable<System.DateTimeOffset> LastCheckedDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual THREATAGENT THREATAGENT { get; set; }
    }
}
