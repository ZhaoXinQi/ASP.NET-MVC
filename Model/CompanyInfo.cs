namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyInfo")]
    public partial class CompanyInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyInfo()
        {
            Balances = new HashSet<Balance>();
            Balance_Pay = new HashSet<Balance_Pay>();
            Jobs = new HashSet<Job>();
            MyCompanies = new HashSet<MyCompany>();
            ZiJians = new HashSet<ZiJian>();
            BLB_Money = new HashSet<BLB_Money>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string C_Email { get; set; }

        [Required]
        [StringLength(20)]
        public string Tel { get; set; }

        [Required]
        [StringLength(50)]
        public string Pwd { get; set; }

        [Required]
        [StringLength(20)]
        public string Com_Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Contacts { get; set; }

        [StringLength(50)]
        public string Business_Img { get; set; }

        [StringLength(50)]
        public string Crad_ID { get; set; }

        [StringLength(50)]
        public string Business { get; set; }

        [StringLength(10)]
        public string Scale { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Detial_Address { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Create_Time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Balance> Balances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Balance_Pay> Balance_Pay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job> Jobs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyCompany> MyCompanies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZiJian> ZiJians { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BLB_Money> BLB_Money { get; set; }
    }
}
