namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Balance")]
    public partial class Balance
    {
        public int ID { get; set; }

        public int C_ID { get; set; }

        public decimal Money { get; set; }

        public DateTime UpdateTime { get; set; }

        public virtual CompanyInfo CompanyInfo { get; set; }
    }
}
