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
    
    public partial class produit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public produit()
        {
            this.approvisionnement = new HashSet<approvisionnement>();
        }
    
        public int idPoduit { get; set; }
        public string libelle { get; set; }
        public string description { get; set; }
        public double QteSeuil { get; set; }
        public Nullable<int> idCategorie { get; set; }
        public string status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<approvisionnement> approvisionnement { get; set; }
        public virtual categorie categorie { get; set; }
    }
}
