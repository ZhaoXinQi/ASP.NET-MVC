namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Balance_Pay
    {
        public int ID { get; set; }

        public int C_ID { get; set; }

        public int? Job_ID { get; set; }

        public decimal Money { get; set; }

        public int method { get; set; }

        [Required]
        [StringLength(50)]
        public string States { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual Job Job { get; set; }

        public virtual CompanyInfo CompanyInfo { get; set; }
    }
}
