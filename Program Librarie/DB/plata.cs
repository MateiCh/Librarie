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
    
    public partial class plata
    {
        public int IdPlata { get; set; }
        public string SerieDocument { get; set; }
        public int NrDocument { get; set; }
        public double Suma { get; set; }
        public int IdFurnizor { get; set; }
        public int IdAchizitie { get; set; }
        public System.DateTime Data { get; set; }
    
        public virtual achizitie achizitie { get; set; }
        public virtual furnizor furnizor { get; set; }
    }
}
