namespace Final460Take2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AllCast")]
    public partial class AllCast
    {
        public int AllCastID { get; set; }

        public int ActorID { get; set; }

        public int MovieID { get; set; }

        public virtual Actor Actor { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
