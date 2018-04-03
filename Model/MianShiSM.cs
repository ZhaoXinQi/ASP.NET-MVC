namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MianShiSMS")]
    public partial class MianShiSM
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int U_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int F_ID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string ComName { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string JobName { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime MStime { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string MSaddress { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(11)]
        public string Tel { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool belongTo { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IsAgree { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime CreateTime { get; set; }
    }
}
