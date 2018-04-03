namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZiJian")]
    public partial class ZiJian
    {
        public int ID { get; set; }

        public int? U_ID { get; set; }

        public int? J_ID { get; set; }

        public int? C_ID { get; set; }

        public bool? Com_IsCheck { get; set; }

        public int? step { get; set; }

        public DateTime? UpdateTime { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime createTime { get; set; }

        public virtual CompanyInfo CompanyInfo { get; set; }

        public virtual Job Job { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
