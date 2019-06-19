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
    
    public partial class event_code
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public event_code()
        {
            this.logs = new HashSet<log>();
        }
    
        public int id { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string system_component { get; set; }
        public string user_description { get; set; }
        public Nullable<int> event_type_id { get; set; }
        public Nullable<int> log_priority_id { get; set; }
        public Nullable<System.DateTime> date_created { get; set; }
        public Nullable<System.DateTime> date_last_modifed { get; set; }
        public Nullable<int> created_by { get; set; }
        public Nullable<int> last_modified_by { get; set; }
        public Nullable<bool> delete_flag { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<log> logs { get; set; }
        public virtual user user { get; set; }
        public virtual event_type event_type { get; set; }
        public virtual log_priority log_priority { get; set; }
        public virtual user user1 { get; set; }
    }
}