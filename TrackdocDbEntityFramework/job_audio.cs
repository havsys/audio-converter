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
    
    public partial class job_audio
    {
        public int id { get; set; }
        public int job_id { get; set; }
        public int audio_id { get; set; }
        public int created_by { get; set; }
        public System.DateTime date_created { get; set; }
        public int last_modified_by { get; set; }
        public System.DateTime date_last_modified { get; set; }
        public bool delete_flag { get; set; }
    
        public virtual audio audio { get; set; }
        public virtual job job { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
