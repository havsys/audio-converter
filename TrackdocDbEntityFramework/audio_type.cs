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
    
    public partial class audio_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public audio_type()
        {
            this.audios = new HashSet<audio>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string MIME_type { get; set; }
        public int created_by { get; set; }
        public int last_modified_by { get; set; }
        public System.DateTime date_created { get; set; }
        public System.DateTime date_last_modified { get; set; }
        public bool delete_flag { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<audio> audios { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
