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
    
    public partial class SECURITYATTRIBUTESTATE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SECURITYATTRIBUTESTATE()
        {
            this.SECURITYATTRIBUTE = new HashSet<SECURITYATTRIBUTE>();
        }
    
        public int SecurityAttributeStateID { get; set; }
        public int SecurityAttributeCategoryID { get; set; }
        public string SecurityAttributeStateName { get; set; }
        public string SecurityAttributeStateDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECURITYATTRIBUTE> SECURITYATTRIBUTE { get; set; }
        public virtual SECURITYATTRIBUTECATEGORY SECURITYATTRIBUTECATEGORY { get; set; }
    }
}