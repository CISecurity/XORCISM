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
    
    public partial class OVALSTATEFIELD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OVALSTATEFIELD()
        {
            this.OVALSTATEFIELDFOROVALSTATERECORD = new HashSet<OVALSTATEFIELDFOROVALSTATERECORD>();
        }
    
        public int OVALStateFieldID { get; set; }
        public Nullable<int> OVALEntityAttributeGroupID { get; set; }
        public string FieldName { get; set; }
        public string DataTypeName { get; set; }
        public Nullable<int> OperationEnumerationID { get; set; }
        public Nullable<int> CheckEnumerationID { get; set; }
        public string FieldValue { get; set; }
        public Nullable<int> OVALNamespaceID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> OVALVariableID { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual OVALENTITYATTRIBUTEGROUP OVALENTITYATTRIBUTEGROUP { get; set; }
        public virtual OVALNAMESPACE OVALNAMESPACE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OVALSTATEFIELDFOROVALSTATERECORD> OVALSTATEFIELDFOROVALSTATERECORD { get; set; }
    }
}