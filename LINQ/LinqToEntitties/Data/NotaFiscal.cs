//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqToEntities.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class NotaFiscal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NotaFiscal()
        {
            this.ItemNotaFiscals = new HashSet<ItemNotaFiscal>();
        }
    
        public int NotaFiscalId { get; set; }
        public int ClienteId { get; set; }
        public System.DateTime DataNotaFiscal { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string CEP { get; set; }
        public decimal Total { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemNotaFiscal> ItemNotaFiscals { get; set; }
    }
}
