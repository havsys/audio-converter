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
    
    public partial class api_encounter
    {
        public int id { get; set; }
        public int oauth_client_id { get; set; }
        public int provider_entity_id { get; set; }
        public string patientFirstName { get; set; }
        public string patientMiddleInitial { get; set; }
        public string patientLastName { get; set; }
        public Nullable<System.DateTime> patientDOB { get; set; }
        public string patientMRN { get; set; }
        public string encounterID { get; set; }
        public string encounterType { get; set; }
        public int encounterStatus { get; set; }
        public System.DateTime scheduledDos { get; set; }
        public Nullable<System.DateTime> encounterBegin { get; set; }
        public Nullable<System.DateTime> encounterEnd { get; set; }
        public int provider_relationship_id { get; set; }
        public string providerFirstName { get; set; }
        public string providerLastName { get; set; }
        public System.DateTime date_created { get; set; }
        public System.DateTime date_last_modified { get; set; }
        public int last_modified_by { get; set; }
        public int created_by { get; set; }
        public bool delete_flag { get; set; }
    
        public virtual api_encounter_status api_encounter_status { get; set; }
        public virtual user user { get; set; }
        public virtual entity entity { get; set; }
        public virtual user user1 { get; set; }
        public virtual oauth_client oauth_client { get; set; }
        public virtual relationship relationship { get; set; }
    }
}
