namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BLB_Money
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int U_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal money { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string states { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime CreateTime { get; set; }

        public virtual CompanyInfo CompanyInfo { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
