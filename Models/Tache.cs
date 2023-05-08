using System.ComponentModel.DataAnnotations;

namespace Todo_List.Models
{
    public class Tache
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(50)]
        public string State { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public int Importance { get; set; }
        public DateTime Deadline { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public User User { get; set; }
    }
}
