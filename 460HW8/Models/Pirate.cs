namespace _460HW8.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pirate")]
    public partial class Pirate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pirate()
        {
            Crews = new HashSet<Crew>();
        }

        [Display(Name = "PirateID")]
        public int PirateID { get; set; }

        [Required]
        [Display(Name = "FirstName")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "LastName")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Display(Name = "Date")]
        [Column(TypeName = "date")]
        [PastDate(ErrorMessage = "Date should not be in the future.")]
        public DateTime Date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Crew> Crews { get; set; }
    }
    public class PastDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value != null && (DateTime)value < DateTime.Now;
        }
    }
}
