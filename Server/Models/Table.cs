namespace Server.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(10)]
        public string Qrcode { get; set; }

        public int? ThisMonth { get; set; }

        public int? AllTime { get; set; }

        [Column(TypeName = "ntext")]
        public string Примечания { get; set; }
    }
}
