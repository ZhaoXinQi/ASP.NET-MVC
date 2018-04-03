namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MyMoney_Pay
    {
        public int ID { get; set; }

        public int? U_ID { get; set; }

        [StringLength(20)]
        public string Pname { get; set; }

        public bool? PayMethod { get; set; }

        public int? Num { get; set; }

        public DateTime? updateTime { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
