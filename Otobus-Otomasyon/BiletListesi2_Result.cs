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
    
    public partial class BiletListesi2_Result
    {
        public int Bilet_Numarası { get; set; }
        public string Ad_Soyad { get; set; }
        public string Kalkış_Yeri { get; set; }
        public string Varış_Yeri { get; set; }
        public Nullable<System.DateTime> biletTarih { get; set; }
        public Nullable<int> koltukNo { get; set; }
        public string PnrNumarasi { get; set; }
        public Nullable<decimal> biletUcreti { get; set; }
        public string BiletDurumu { get; set; }
    }
}
