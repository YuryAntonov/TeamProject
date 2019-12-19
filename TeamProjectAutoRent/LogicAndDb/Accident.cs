namespace LogicAndDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Accident")]
    public partial class Accident
    {
        [Key]
        public int accident_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal damage { get; set; }

        [StringLength(200)]
        public string damage_description { get; set; }

        [Column(TypeName = "date")]
        public DateTime accident_date { get; set; }

        [StringLength(8)]
        public string carplate_number { get; set; }

        public virtual Car Car { get; set; }
    }
}
