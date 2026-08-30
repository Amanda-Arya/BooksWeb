using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksWeb.Model
{
    [Table("Books")]
    public class Book
    {
        [Required]
        [Column("title", TypeName = "varchar(max)")]
        public string Title { get; set; }
        [Required]
        [Column("author", TypeName = "varchar(50)")]
        public string Author { get; set; }
        [Required]
        [Column("gender", TypeName = "varchar(50)")]
        public string Gender { get; set; }
        [Required]
        [Column("publisher", TypeName = "varchar(50)")]
        public string Publisher { get; set; }
        [Required]
        [Column("year", TypeName = "int")]
        public int Year { get; set; }
        [Required]
        [Column("pagesNumber", TypeName = "int")]
        public int PagesNUmber { get; set; }
        [Required]
        [Column("ISBN", TypeName = "int")]
        public int ISBN { get; set; }


    }
}
