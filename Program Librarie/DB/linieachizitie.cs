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
    
    public partial class linieachizitie
    {
        public int IdAchizitie { get; set; }
        public int IdProdus { get; set; }
        public int Cantitate { get; set; }
        public double Pret { get; set; }
    
        public virtual achizitie achizitie { get; set; }
        public virtual produs produs { get; set; }
    }
}
