//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestorContatos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Telefone
    {
        public int CodFone { get; set; }
        public int CodContato { get; set; }
        public string Numero { get; set; }
        public int CodOperadora { get; set; }
    
        public virtual Contato Contato { get; set; }
        public virtual Operadora Operadora { get; set; }
    }
}
