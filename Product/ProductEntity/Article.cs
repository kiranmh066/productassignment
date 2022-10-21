using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProductEntity
{
    public class Article
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid articleId { get; set; }

        public string articleName { get; set; }

        /*[ForeignKey("tblProduct")]
        public int ProductId { get; set; }//Foreign Key
        public Product tblProduct { get; set; }*/

        [ForeignKey("tblColor")]
        public Guid colorId { get; set; }//Foreign Key

        public Color tblColor { get; set; }

        
    }
}
