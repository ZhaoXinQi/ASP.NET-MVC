namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TuiJian_Resume
    {
        public int ID { get; set; }

        public int? U_ID { get; set; }

        public int? UU_ID { get; set; }

        public int? Job_ID { get; set; }

        public int? Step { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Createtime { get; set; }

        public virtual Job Job { get; set; }

        public virtual UserInfo UserInfo { get; set; }

        public virtual UserInfo UserInfo1 { get; set; }
    }
}
