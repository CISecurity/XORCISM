//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XWINDOWSModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class WINDOWSMUTEXSECURITYATTRIBUTE
    {
        public int WindowsMutexSecurityAttributeID { get; set; }
        public int WindowsMutexID { get; set; }
        public int SecurityAttributeID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
    
        public virtual WINDOWSMUTEX WINDOWSMUTEX { get; set; }
    }
}