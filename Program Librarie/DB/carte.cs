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
    
    public partial class carte
    {
        public int IdCarte { get; set; }
        public string ISBN { get; set; }
        public string Titlu { get; set; }
        public string Descriere { get; set; }
        public int IdEditura { get; set; }
        public int An { get; set; }
        public int NrPagini { get; set; }
        public string Locatie { get; set; }
        public int IdAutor { get; set; }
        public int IdDomeniu { get; set; }
    
        public virtual autor autor { get; set; }
        public virtual domeniu domeniu { get; set; }
        public virtual editura editura { get; set; }
    }
}
