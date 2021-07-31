using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Drugstore.Models
{
    public class Drug
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(256)]
        public string Name { get; set; }
        public int soLuong { get; set; }

        public string nhaSX { get; set;}
    }
}