namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pro_Exper
    {
        public int Id { get; set; }

        public int? U_ID { get; set; }

        [StringLength(20)]
        public string Project_Name { get; set; }

        [StringLength(20)]
        public string StartEnd_Time { get; set; }

        [Column(TypeName = "text")]
        public string Project_Desc { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Create_Time { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
