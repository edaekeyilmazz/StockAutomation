namespace StokOtomasyon.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hareket")]
    public partial class Hareket
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public Guid StokID { get; set; }

        public Guid DepoID { get; set; }

        [Required]
        [StringLength(20)]
        public string FirmaAdi { get; set; }

        [Required]
        public byte HareketTuru { get; set; }

        public decimal? Miktar { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual Depo Depo { get; set; }

        public virtual Stok Stok { get; set; }
    }
}
