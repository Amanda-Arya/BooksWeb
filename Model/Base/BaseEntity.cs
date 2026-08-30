using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksWeb.Model.Base
{
    public class BaseEntity
    {
        [Key] //primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //auto increment
        [Column("id")]
        public long Id { get; set; }
    }
}
