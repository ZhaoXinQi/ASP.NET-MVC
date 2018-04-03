namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Work_Exper
    {
        public int Id { get; set; }

        public int? U_ID { get; set; }

        [StringLength(50)]
        public string Com_Name { get; set; }

        [StringLength(20)]
        public string StartEnd_Time { get; set; }

        [StringLength(20)]
        public string Depart_Name { get; set; }

        [StringLength(20)]
        public string Position_Nmae { get; set; }

        [StringLength(20)]
        public string Industry { get; set; }

        [Column(TypeName = "text")]
        public string Job_desc { get; set; }

        public DateTime? Create_Time { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
