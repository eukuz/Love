namespace Love.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Uvlechenia")]
    public partial class Uvlechenia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uvlechenia()
        {
            Anketa = new HashSet<Anketa>();
        }

        public int Id { get; set; }

        public bool? Sport { get; set; }

        public bool? Travelling { get; set; }

        public bool? TV { get; set; }

        public bool? Shopping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Anketa> Anketa { get; set; }
    }
}
