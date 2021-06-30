namespace Tuan3_Bai1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage ="Id khong duoc bo trong")]
        public int ID { get; set; }

        [StringLength(50, ErrorMessage = "do dai khong lon hon 50")]
        public string TITLE { get; set; }

        [StringLength(50, ErrorMessage = "do dai khong lon hon 50")]
        public string AUTHOR { get; set; }

        [Range(1,1000000,ErrorMessage ="gia phai lon hon 0-nho hon 1000000")]
        public double? PRICE { get; set; }

        [StringLength(50)]
        public string IMAGES { get; set; }
    }
}
