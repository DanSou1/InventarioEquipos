using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Inventario_Equipos.Models
{
    public class Computer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Serial { get; set; }
        [Required]
        [MaxLength(50)]
        public string BrandName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Model { get; set; }
        [Required]
        [MaxLength(100)]
        public string OperatingSystem { get; set; }
        [Required]
        public bool isFunctional { get; set; }
    }
}
