//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SzerszamgepKereskedelem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class eladasok
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public eladasok()
        {
            this.megrendeles = new HashSet<megrendeles>();
        }
    
        public int id { get; set; }
        public System.DateTime datum { get; set; }
        public string tipus { get; set; }
        public string szamlaszam { get; set; }
        public string EKAR_Szam { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<megrendeles> megrendeles { get; set; }
    }
}