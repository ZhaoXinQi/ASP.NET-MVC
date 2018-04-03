namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CertificateInfo")]
    public partial class CertificateInfo
    {
        public int Id { get; set; }

        public int? U_ID { get; set; }

        [StringLength(10)]
        public string Certi_Name { get; set; }

        [StringLength(10)]
        public string GetTime { get; set; }

        public int? Score { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Create_Time { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
