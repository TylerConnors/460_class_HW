namespace Final460Take2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movie")]
    public partial class Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            AllCasts = new HashSet<AllCast>();
        }

        public int MovieID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public int Year { get; set; }

        public int DirectorID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AllCast> AllCasts { get; set; }

        public virtual Director Director { get; set; }
    }
}
