//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrackdocDbEntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class invoice
    {
        public int id { get; set; }
        public string name { get; set; }
        public string filename { get; set; }
        public byte[] invoice_lob { get; set; }
        public int document_type_id { get; set; }
        public int entity_id { get; set; }
        public System.DateTime period_startdate { get; set; }
        public System.DateTime period_enddate { get; set; }
        public System.DateTime date_created { get; set; }
        public System.DateTime date_last_modified { get; set; }
        public int last_modified_by { get; set; }
        public int created_by { get; set; }
        public bool delete_flag { get; set; }
    
        public virtual document_type document_type { get; set; }
        public virtual entity entity { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}