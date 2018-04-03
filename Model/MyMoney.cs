namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MyMoney")]
    public partial class MyMoney
    {
        public int ID { get; set; }

        public int? U_ID { get; set; }

        public decimal? Money { get; set; }

        [Column(TypeName = "date")]
        public DateTime? updateTime { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
