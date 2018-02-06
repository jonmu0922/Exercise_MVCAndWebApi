namespace Exercise_MVCAndWebApi.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SysUser")]
    public partial class SysUser
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Age { get; set; }
    }
}
