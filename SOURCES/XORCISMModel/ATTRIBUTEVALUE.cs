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
    
    public partial class ATTRIBUTEVALUE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ATTRIBUTEVALUE()
        {
            this.SESSIONCOOKIEATTRIBUTEVALUE = new HashSet<SESSIONCOOKIEATTRIBUTEVALUE>();
        }
    
        public int AttributeValueID { get; set; }
        public int AttributeID { get; set; }
        public string AttributeValueName { get; set; }
        public string AttributeValueDescription { get; set; }
        public string AttributeValueType { get; set; }
        public string AttributeValue1 { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual ATTRIBUTE ATTRIBUTE { get; set; }
        public virtual CONFIDENCELEVEL CONFIDENCELEVEL { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SESSIONCOOKIEATTRIBUTEVALUE> SESSIONCOOKIEATTRIBUTEVALUE { get; set; }
    }
}
