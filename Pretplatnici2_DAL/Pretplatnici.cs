//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pretplatnici2_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pretplatnici
    {
        public int PredplatnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public string KorisnickoIme { get; set; }
        public Nullable<bool> Aktivan { get; set; }
        public int StrucnaSpremaID { get; set; }
        public byte[] Slika { get; set; }
        public byte[] Cv { get; set; }
    
        public virtual StrucnaSprema StrucnaSprema { get; set; }
    }
}