//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YemekhaneOtomasyonu
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ögrenci
    {
        public int ögrenciID { get; set; }
        public string ÖgrenciAd { get; set; }
        public string ögrenciSoyad { get; set; }
        public string ögrenciNumarası { get; set; }
        public string ögrenciSifre { get; set; }
        public Nullable<int> ögrenciBakiyeID { get; set; }
        public Nullable<bool> ögrenciDurum { get; set; }
        public string ögrenciTC { get; set; }
        public string ögrenciDoğumYıl { get; set; }
    
        public virtual ögrenciBakiye ögrenciBakiye { get; set; }
    }
}
