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
    
    public partial class ACTIVATIONZONEFORATTACKPATTERN
    {
        public int AttackPatternActivationZoneID { get; set; }
        public string AttackPatternActivationZoneGUID { get; set; }
        public int ActivationZoneID { get; set; }
        public string ActivationZoneGUID { get; set; }
        public int AttackPatternID { get; set; }
        public string AttackPatternGUID { get; set; }
        public string capec_id { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual ACTIVATIONZONE ACTIVATIONZONE { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}
