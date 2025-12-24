namespace DoAnWD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHoc")]
    public partial class LopHoc
    {
        [Key]
        public int MaLop { get; set; }

        public int? MaGS { get; set; }

        public int? MaHV { get; set; }

        [StringLength(50)]
        public string MonHoc { get; set; }

        public decimal? HocPhi { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public virtual GiaSu GiaSu { get; set; }

        public virtual HocVien HocVien { get; set; }
    }
}
