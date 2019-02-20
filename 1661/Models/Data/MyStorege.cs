namespace _1661.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MyStorege
    {
        [Key]
        public int IDMS { get; set; }

        public int Dimensions { get; set; }

        public DateTime DAT { get; set; }

        public double MEP { get; set; }

        public string Notes { get; set; }

        [Required]
        [StringLength(50)]
        public string NameOfRP { get; set; }

        public int? IDst { get; set; }

        public int? IDsf { get; set; }

        public virtual SF SF { get; set; }

        public virtual ST ST { get; set; }
    }
}
