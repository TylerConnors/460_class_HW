namespace Final460.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Classification")]
    public partial class Classification
    {
        [Key]
        public int ClassID { get; set; }

        public int ArtWorkID { get; set; }

        public int GenreID { get; set; }

        public virtual ArtWork ArtWork { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
