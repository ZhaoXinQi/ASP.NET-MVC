namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TuiJianXin")]
    public partial class TuiJianXin
    {
        public int ID { get; set; }

        public int U_ID { get; set; }

        public int C_ID { get; set; }

        public int J_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        public int? age { get; set; }

        public bool? sex { get; set; }

        [Required]
        [StringLength(15)]
        public string tel { get; set; }

        [Column(TypeName = "text")]
        public string reason { get; set; }

        public bool? Com_IsCheck { get; set; }

        [Required]
        [StringLength(10)]
        public string Step { get; set; }

        public DateTime UpteTime { get; set; }
    }
}
