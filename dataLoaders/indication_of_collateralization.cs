//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dataLoaders
{
    using System;
    using System.Collections.Generic;
    
    public partial class indication_of_collateralization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public indication_of_collateralization()
        {
            this.dtcc_transactions = new HashSet<dtcc_transactions>();
        }
    
        public byte id { get; set; }
        public string collateratization_key { get; set; }
        public string description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dtcc_transactions> dtcc_transactions { get; set; }
    }
}