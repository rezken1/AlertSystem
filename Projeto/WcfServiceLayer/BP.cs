//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class BP
    {
        public int Id { get; set; }
        public System.DateTime Data { get; set; }
        public int Valor1 { get; set; }
        public int Valor2 { get; set; }
        public bool Alerta { get; set; }
    
        public virtual Utente Utente { get; set; }
    }
}