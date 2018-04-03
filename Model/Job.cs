namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Job")]
    public partial class Job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job()
        {
            Balance_Pay = new HashSet<Balance_Pay>();
            TuiJian_Resume = new HashSet<TuiJian_Resume>();
            ZiJians = new HashSet<ZiJian>();
        }

        public int ID { get; set; }

        public int? C_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Pay { get; set; }

        [Required]
        [StringLength(50)]
        public string Work_Address { get; set; }

        [StringLength(10)]
        public string Edu_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Work_Sort { get; set; }

        [Required]
        [StringLength(50)]
        public string Work_Better { get; set; }

        [Required]
        [StringLength(10)]
        public string Work_Time { get; set; }

        public int NeedPerson { get; set; }

        [Required]
        [StringLength(20)]
        public string Work_Exper { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Require { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Content { get; set; }

        public int ShangJin { get; set; }

        public int? States { get; set; }

        public DateTime CreateTime { get; set; }

        public bool? IsTop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Balance_Pay> Balance_Pay { get; set; }

        public virtual CompanyInfo CompanyInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TuiJian_Resume> TuiJian_Resume { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZiJian> ZiJians { get; set; }
    }
}
