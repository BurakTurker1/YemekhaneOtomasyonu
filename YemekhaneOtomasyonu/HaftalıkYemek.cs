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
    
    public partial class HaftalıkYemek
    {
        public int haftalıkYemekID { get; set; }
        public Nullable<int> haftaNumarası { get; set; }
        public Nullable<int> yemekID { get; set; }
        public string hGün1 { get; set; }
        public string hGün2 { get; set; }
        public string hGün3 { get; set; }
        public string hGün4 { get; set; }
        public string hGün5 { get; set; }
        public string hGün6 { get; set; }
        public string hGün7 { get; set; }
    
        public virtual Yemek Yemek { get; set; }
    }
}
