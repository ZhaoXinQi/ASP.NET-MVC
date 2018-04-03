namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MyCompany")]
    public partial class MyCompany
    {
        public int ID { get; set; }

        public int? U_ID { get; set; }

        public int? Com_ID { get; set; }

        public int? Prize { get; set; }

        public DateTime? Create_Time { get; set; }

        public virtual CompanyInfo CompanyInfo { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
