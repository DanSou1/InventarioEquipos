using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace Inventario_Equipos.Models
{
    public class Assignment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
        public int ComputerId { get; set; }
        [JsonIgnore]
        public Computer Computer { get; set; }
        [Required]
        public DateTime AssignedAt { get; set; }
        public DateTime? ReturnedAt { get; set; }

    }
}
