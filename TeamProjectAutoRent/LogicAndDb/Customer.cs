namespace LogicAndDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Lease_contract = new HashSet<Lease_contract>();
            Purchase_contract = new HashSet<Purchase_contract>();
        }

        [Key]
        [StringLength(10)]
        public string passport_number { get; set; }

        [Required]
        [StringLength(40)]
        public string full_name { get; set; }

        public int driving_experience { get; set; }

        [Required]
        [StringLength(11)]
        public string phone_number { get; set; }

        [StringLength(100)]
        public string customer_address { get; set; }

        [Required]
        [StringLength(1)]
        public string gender { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lease_contract> Lease_contract { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase_contract> Purchase_contract { get; set; }
    }
}
