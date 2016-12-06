namespace _460HW8.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Crew")]
    public partial class Crew
    {
        public int CrewID { get; set; }

        public int PirateID { get; set; }

        public int ShipID { get; set; }

        public decimal Booty { get; set; }

        public virtual Pirate Pirate { get; set; }

        public virtual Ship Ship { get; set; }
    }
}
