namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_WeChat
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
        [StringLength(50)]
        public string WeChat { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "date")]
        public DateTime EditTime { get; set; }
    }
}
