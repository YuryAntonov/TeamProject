namespace LogicAndDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Purchase_contract
    {
        [Key]
        public int contract_number { get; set; }

        [StringLength(10)]
        public string passport_number { get; set; }

        [StringLength(8)]
        public string carplate_number { get; set; }

        [StringLength(100)]
        public string office_address { get; set; }

        [Column(TypeName = "numeric")]
        public decimal amount { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public virtual Car Car { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Office Office { get; set; }
    }
}
