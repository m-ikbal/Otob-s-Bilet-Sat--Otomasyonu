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
    
    public partial class Yolcular
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Yolcular()
        {
            this.Biletler = new HashSet<Biletler>();
            this.Rezervasyon = new HashSet<Rezervasyon>();
        }
    
        public int yolcuId { get; set; }
        public string yolcuAdi { get; set; }
        public string yolcuSoyadi { get; set; }
        public string yolcuTc { get; set; }
        public string yolcuTelNo { get; set; }
        public string yolcuEposta { get; set; }
        public Nullable<System.DateTime> yolcuDogumTarihi { get; set; }
        public string yolcuCinsiyet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Biletler> Biletler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervasyon> Rezervasyon { get; set; }
    }
}
