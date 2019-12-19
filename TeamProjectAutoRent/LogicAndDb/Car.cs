namespace LogicAndDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            Accident = new HashSet<Accident>();
            Lease_contract = new HashSet<Lease_contract>();
            Purchase_contract = new HashSet<Purchase_contract>();
        }

        [Key]
        [StringLength(8)]
        public string carplate_number { get; set; }

        [Column(TypeName = "numeric")]
        public decimal mileage { get; set; }

        [Required]
        [StringLength(15)]
        public string car_status { get; set; }

        [Required]
        [StringLength(50)]
        public string color { get; set; }

        [StringLength(40)]
        public string model_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accident> Accident { get; set; }

        public virtual Car_model Car_model { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lease_contract> Lease_contract { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase_contract> Purchase_contract { get; set; }
    }
}
