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
    
    public partial class beszerzesek
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public beszerzesek()
        {
            this.megrendeles = new HashSet<megrendeles>();
        }
    
        public int id { get; set; }
        public System.DateTime datum { get; set; }
        public string beszerzes_Tipus { get; set; }
        public string EKAR_Szam { get; set; }
        public string szamla { get; set; }
        public string VAM { get; set; }
        public string fuvar { get; set; }
        public string CMR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<megrendeles> megrendeles { get; set; }
    }
}
