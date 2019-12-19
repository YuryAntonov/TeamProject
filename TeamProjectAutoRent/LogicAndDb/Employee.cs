namespace LogicAndDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [StringLength(10)]
        public string passport_number { get; set; }

        [Column(TypeName = "date")]
        public DateTime birth_date { get; set; }

        [Required]
        [StringLength(1)]
        public string gender { get; set; }

        [StringLength(100)]
        public string office_address { get; set; }

        [StringLength(40)]
        public string full_name { get; set; }

        public virtual Office Office { get; set; }
    }
}
