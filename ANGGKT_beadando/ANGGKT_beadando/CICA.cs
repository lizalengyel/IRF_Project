//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ANGGKT_beadando
{
    using System;
    using System.Collections.Generic;
    
    public partial class CICA
    {
        public int cica_id { get; set; }
        public string nev { get; set; }
        public int kor { get; set; }
        public string szin { get; set; }
        public string fajta { get; set; }
        public System.DateTime felvetel { get; set; }
        public bool van_egazdi { get; set; }
        public Nullable<int> gazda_fk { get; set; }
    
        public virtual Gazda Gazda { get; set; }
    }
}