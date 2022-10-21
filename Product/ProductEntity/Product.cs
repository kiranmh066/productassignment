using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductEntity
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid productId { get; set; }

        public string productName { get; set; }

        public int productYear { get; set; }
        public int channelId { get; set; }

        [ForeignKey("tblSize")]
        public Guid sizeId { get; set; }//Foreign Key

        public SizeScale tblSize { get; set; }

        [ForeignKey("tblArticle")]

        public Article[] articles { get; set; }
        public Article tblArticle { get; set; }


        public DateTime createDate { get; set; }

        public string createdBy { get; set; }

        public string ProductCode { get; set; }
    }
}
