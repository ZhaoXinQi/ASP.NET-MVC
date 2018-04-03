namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("resume")]
    public partial class resume
    {
        public int ID { get; set; }

        public int? U_ID { get; set; }

        [StringLength(20)]
        public string Expected_Job { get; set; }

        [StringLength(20)]
        public string Expected_Industry { get; set; }

        [StringLength(50)]
        public string Working_Area { get; set; }

        [StringLength(10)]
        public string Expected_Salary { get; set; }

        [StringLength(50)]
        public string Professional { get; set; }

        [StringLength(20)]
        public string Language_Ability { get; set; }

        [Column(TypeName = "text")]
        public string Pingjia { get; set; }

        public int? WanSanDu { get; set; }

        public DateTime? Create_Time { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
