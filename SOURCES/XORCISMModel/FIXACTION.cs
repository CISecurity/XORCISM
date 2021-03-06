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
    
    public partial class FIXACTION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIXACTION()
        {
            this.CPEFORFIXACTION = new HashSet<CPEFORFIXACTION>();
            this.FIXACTIONFORFIXACTION = new HashSet<FIXACTIONFORFIXACTION>();
            this.FIXACTIONFORFIXACTION1 = new HashSet<FIXACTIONFORFIXACTION>();
            this.FIXACTIONFORINCIDENT = new HashSet<FIXACTIONFORINCIDENT>();
            this.FIXACTIONFORVULNERABILITY = new HashSet<FIXACTIONFORVULNERABILITY>();
            this.FIXACTIONPATCH = new HashSet<FIXACTIONPATCH>();
        }
    
        public int FixActionID { get; set; }
        public string FixActionGUID { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string source { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public string lang { get; set; }
        public string id { get; set; }
        public Nullable<bool> reboot { get; set; }
        public string strategy { get; set; }
        public string disruption { get; set; }
        public string complexity { get; set; }
        public string systemURI { get; set; }
        public string platformURI { get; set; }
        public string XCCDFContent { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPEFORFIXACTION> CPEFORFIXACTION { get; set; }
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        public virtual VOCABULARY VOCABULARY1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIXACTIONFORFIXACTION> FIXACTIONFORFIXACTION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIXACTIONFORFIXACTION> FIXACTIONFORFIXACTION1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIXACTIONFORINCIDENT> FIXACTIONFORINCIDENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIXACTIONFORVULNERABILITY> FIXACTIONFORVULNERABILITY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIXACTIONPATCH> FIXACTIONPATCH { get; set; }
    }
}
