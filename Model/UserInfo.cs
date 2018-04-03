namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserInfo")]
    public partial class UserInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserInfo()
        {
            CertificateInfoes = new HashSet<CertificateInfo>();
            Edu_Exper = new HashSet<Edu_Exper>();
            MyCompanies = new HashSet<MyCompany>();
            MyMoneys = new HashSet<MyMoney>();
            MyMoney_Pay = new HashSet<MyMoney_Pay>();
            Pro_Exper = new HashSet<Pro_Exper>();
            resumes = new HashSet<resume>();
            TuiJian_Resume = new HashSet<TuiJian_Resume>();
            TuiJian_Resume1 = new HashSet<TuiJian_Resume>();
            Work_Exper = new HashSet<Work_Exper>();
            ZiJians = new HashSet<ZiJian>();
            BLB_Money = new HashSet<BLB_Money>();
            UserCards = new HashSet<UserCard>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string OpenID { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public bool? Sex { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public DateTime? Birthday { get; set; }

        [StringLength(11)]
        public string Tel { get; set; }

        [StringLength(10)]
        public string Edu { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        public bool? MaritalStatus { get; set; }

        [StringLength(10)]
        public string WorkYear { get; set; }

        public bool? IsWork { get; set; }

        [StringLength(150)]
        public string Img { get; set; }

        public int? S_ID { get; set; }

        public DateTime? Create_Time { get; set; }

        [StringLength(16)]
        public string U_IP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CertificateInfo> CertificateInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Edu_Exper> Edu_Exper { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyCompany> MyCompanies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyMoney> MyMoneys { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyMoney_Pay> MyMoney_Pay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pro_Exper> Pro_Exper { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<resume> resumes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TuiJian_Resume> TuiJian_Resume { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TuiJian_Resume> TuiJian_Resume1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Work_Exper> Work_Exper { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZiJian> ZiJians { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BLB_Money> BLB_Money { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserCard> UserCards { get; set; }
    }
}
