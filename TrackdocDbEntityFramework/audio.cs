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
    
    public partial class audio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public audio()
        {
            this.job_audio = new HashSet<job_audio>();
            this.speechrec_job = new HashSet<speechrec_job>();
        }
    
        public int id { get; set; }
        public string filename { get; set; }
        public byte[] audio_lob { get; set; }
        public int relationship_id { get; set; }
        public Nullable<int> external_id { get; set; }
        public int audio_type_id { get; set; }
        public string bitrate { get; set; }
        public int audio_source_id { get; set; }
        public Nullable<int> length { get; set; }
        public int created_by { get; set; }
        public int last_modified_by { get; set; }
        public System.DateTime date_created { get; set; }
        public System.DateTime date_last_modified { get; set; }
        public bool delete_flag { get; set; }
        public bool purged { get; set; }
    
        public virtual audio_source audio_source { get; set; }
        public virtual audio_type audio_type { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
        public virtual relationship relationship { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<job_audio> job_audio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<speechrec_job> speechrec_job { get; set; }
    }
}