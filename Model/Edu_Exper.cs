namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Edu_Exper
    {
        public int Id { get; set; }

        public int? U_ID { get; set; }

        [StringLength(20)]
        public string School_Name { get; set; }

        [StringLength(20)]
        public string StartEnd_Time { get; set; }

        [StringLength(15)]
        public string Major { get; set; }

        [StringLength(10)]
        public string E_ID { get; set; }

        [Column(TypeName = "text")]
        public string Pro_desc { get; set; }

        public DateTime? Create_Time { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
