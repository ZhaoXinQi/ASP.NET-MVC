namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserCard")]
    public partial class UserCard
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
        [StringLength(20)]
        public string CardNum { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string CardName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string CardAddress { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(11)]
        public string Tel { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string ZXName { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "date")]
        public DateTime EditTime { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
