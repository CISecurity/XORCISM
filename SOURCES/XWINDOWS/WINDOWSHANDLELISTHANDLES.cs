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
    
    public partial class WINDOWSHANDLELISTHANDLES
    {
        public int WindowsHandleListHandlesID { get; set; }
        public int WindowsHandleListID { get; set; }
        public int WindowsHandleID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public Nullable<int> CollectionMethodID { get; set; }
    
        public virtual WINDOWSHANDLE WINDOWSHANDLE { get; set; }
        public virtual WINDOWSHANDLELIST WINDOWSHANDLELIST { get; set; }
    }
}