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
    
    public partial class produs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public produs()
        {
            this.linieachizitie = new HashSet<linieachizitie>();
            this.linieoferta = new HashSet<linieoferta>();
            this.linievanzare = new HashSet<linievanzare>();
        }
    
        public int IdProdus { get; set; }
        public int IdTipProdus { get; set; }
        public int Produs1 { get; set; }
        public double Pret { get; set; }
        public int Cantitate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<linieachizitie> linieachizitie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<linieoferta> linieoferta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<linievanzare> linievanzare { get; set; }
        public virtual tipprodus tipprodus { get; set; }
    }
}
