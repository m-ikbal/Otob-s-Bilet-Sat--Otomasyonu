//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Otobus_Otomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seferler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seferler()
        {
            this.Biletler = new HashSet<Biletler>();
        }
    
        public int seferId { get; set; }
        public Nullable<System.TimeSpan> VarisSaati { get; set; }
        public Nullable<System.TimeSpan> KalkisSaati { get; set; }
        public string Kalkis { get; set; }
        public string Varis { get; set; }
        public Nullable<int> aracId { get; set; }
        public string seferDurum { get; set; }
        public string SeferVarisTarihi { get; set; }
        public string SeferKalkisTarihi { get; set; }
    
        public virtual Araclar Araclar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Biletler> Biletler { get; set; }
    }
}
