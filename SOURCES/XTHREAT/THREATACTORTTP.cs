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
    
    public partial class THREATACTORTTP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THREATACTORTTP()
        {
            this.THREATACTORINFRASTRUCTUREFORTHREATACTORTTP = new HashSet<THREATACTORINFRASTRUCTUREFORTHREATACTORTTP>();
            this.THREATACTORTTPFORINCIDENT = new HashSet<THREATACTORTTPFORINCIDENT>();
            this.THREATACTORTTPFORINDICATOR = new HashSet<THREATACTORTTPFORINDICATOR>();
            this.THREATACTORTTPFORTHREATACTORTTP = new HashSet<THREATACTORTTPFORTHREATACTORTTP>();
            this.THREATACTORTTPFORTHREATACTORTTP1 = new HashSet<THREATACTORTTPFORTHREATACTORTTP>();
            this.THREATINTENDEDEFFECTFORTHREATACTORTTP = new HashSet<THREATINTENDEDEFFECTFORTHREATACTORTTP>();
        }
    
        public int ThreatActorTTPID { get; set; }
        public string TTPTitle { get; set; }
        public string TTPDescription { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public string Information_Source { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THREATACTORINFRASTRUCTUREFORTHREATACTORTTP> THREATACTORINFRASTRUCTUREFORTHREATACTORTTP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THREATACTORTTPFORINCIDENT> THREATACTORTTPFORINCIDENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THREATACTORTTPFORINDICATOR> THREATACTORTTPFORINDICATOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THREATACTORTTPFORTHREATACTORTTP> THREATACTORTTPFORTHREATACTORTTP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THREATACTORTTPFORTHREATACTORTTP> THREATACTORTTPFORTHREATACTORTTP1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THREATINTENDEDEFFECTFORTHREATACTORTTP> THREATINTENDEDEFFECTFORTHREATACTORTTP { get; set; }
    }
}
