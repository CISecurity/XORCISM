//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XOVALModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class OVALITEMATTRIBUTEGROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OVALITEMATTRIBUTEGROUP()
        {
            this.OVALITEMCOMPLEXBASE = new HashSet<OVALITEMCOMPLEXBASE>();
            this.OVALITEMSIMPLEBASE = new HashSet<OVALITEMSIMPLEBASE>();
        }
    
        public int OVALItemAttributeGroupID { get; set; }
        public string DataTypeName { get; set; }
        public Nullable<bool> mask { get; set; }
        public string StatusName { get; set; }
        public string OVALItemIDPattern { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OVALITEMCOMPLEXBASE> OVALITEMCOMPLEXBASE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OVALITEMSIMPLEBASE> OVALITEMSIMPLEBASE { get; set; }
    }
}