namespace Love.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Anketa")]
    public partial class Anketa
    {
        public int Id { get; set; }

        [Required]
        public string FIO { get; set; }

        public int? Age { get; set; }

        [Required]
        [StringLength(1)]
        public string Pol { get; set; }

        public int? UvlecheniaiId { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public int CityId { get; set; }

        public virtual Uvlechenia Uvlechenia { get; set; }

        public virtual City City { get; set; }

    }
}
