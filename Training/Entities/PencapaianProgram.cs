namespace Training.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PencapaianProgram")]
    public partial class PencapaianProgram
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(500)]
        public string KodProgram { get; set; }

        public DateTime? TarikhProgram { get; set; }

        public int? BilanganHari { get; set; }

        public bool? Lulus { get; set; }

        public bool? Terhapus { get; set; }
    }
}
