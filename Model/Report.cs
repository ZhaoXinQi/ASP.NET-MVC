namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Report")]
    public partial class Report
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
        public int TID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string Content { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Belong { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime CreateTime { get; set; }
    }
}
