//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PointDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job()
        {
            this.AppliedFors = new HashSet<AppliedFor>();
        }
    
        public int JobID { get; set; }
        public string Title { get; set; }
        public string Organization { get; set; }
        public System.DateTime LastApplyDate { get; set; }
        public string Designation { get; set; }
        public int MinExperience { get; set; }
        public string Attachmentpath { get; set; }
        public string ApplicationLink { get; set; }
        public string Contactperson { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppliedFor> AppliedFors { get; set; }
    }
}
