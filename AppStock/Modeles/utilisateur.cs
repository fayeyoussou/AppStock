//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppStock.Modeles
{
    using System;
    using System.Collections.Generic;
    
    public partial class utilisateur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public utilisateur()
        {
            this.facture = new HashSet<facture>();
        }
    
        public int idUtilisateur { get; set; }
        public string identifiant { get; set; }
        public string motDePasse { get; set; }
        public string email { get; set; }
        public string status { get; set; }
        public int idRole { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<facture> facture { get; set; }
        public virtual role role { get; set; }
    }
}