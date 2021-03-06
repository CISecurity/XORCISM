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
    
    public partial class ACCOUNTCHANGERECORD
    {
        public int AccountChangeRecordID { get; set; }
        public string AccountChangeRecordGUID { get; set; }
        public int AccountID { get; set; }
        public string AccountGUID { get; set; }
        public int ChangeRecordID { get; set; }
        public string ChangeRecordGUID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual ACCOUNT ACCOUNT { get; set; }
        public virtual CHANGERECORD CHANGERECORD { get; set; }
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
    }
}
