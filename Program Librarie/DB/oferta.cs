//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Program_Librarie.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class oferta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public oferta()
        {
            this.linieoferta = new HashSet<linieoferta>();
        }
    
        public int IdOferta { get; set; }
        public System.DateTime DataExpirare { get; set; }
        public int IdFurnizor { get; set; }
    
        public virtual furnizor furnizor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<linieoferta> linieoferta { get; set; }
    }
}