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
    
    public partial class ARFRELATIONSHIP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ARFRELATIONSHIP()
        {
            this.ARFASSET = new HashSet<ARFASSET>();
            this.ARFRELATIONSHIPS = new HashSet<ARFRELATIONSHIPS>();
            this.REPORT = new HashSet<REPORT>();
            this.REPORTREQUEST = new HashSet<REPORTREQUEST>();
        }
    
        public int ARFRelationshipID { get; set; }
        public string RelationshipTypeQName { get; set; }
        public Nullable<int> RelationshipTypeID { get; set; }
        public string RelationshipScope { get; set; }
        public string RelationshipSubjectNCName { get; set; }
    
        public virtual RELATIONSHIPTYPE RELATIONSHIPTYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARFASSET> ARFASSET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARFRELATIONSHIPS> ARFRELATIONSHIPS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPORT> REPORT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPORTREQUEST> REPORTREQUEST { get; set; }
    }
}