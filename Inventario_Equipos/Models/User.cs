using System.ComponentModel.DataAnnotations;

namespace Inventario_Equipos.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Area { get; set; }
        [Required]
        [MaxLength(100)]
        public string JobPosition { get; set; }
        [MaxLength(3)]
        public string? Ext { get; set; }
        [Required]
        [MaxLength(125)]
        public string Email { get; set; }
    }
}
