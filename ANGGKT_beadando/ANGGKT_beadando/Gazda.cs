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
    
    public partial class Gazda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gazda()
        {
            this.CICAs = new HashSet<CICA>();
        }
    
        public int gazda_id { get; set; }
        public string nev { get; set; }
        public string telefonszam { get; set; }
        public Nullable<int> kor { get; set; }
        public System.DateTime orokbefogdatum { get; set; }
        public int account_fk { get; set; }
    
        public virtual Account Account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CICA> CICAs { get; set; }
    }
}