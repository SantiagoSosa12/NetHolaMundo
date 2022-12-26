using System.ComponentModel.DataAnnotations;

namespace holaMundo.Models.DataModels {

    public class BaseEntity {

        [Required]
        [Key]
        public int Id { get; set; }
        public string createdBy { get; set; } = string.Empty;
        public DateTime createAt { get; set; } = DateTime.Now;
        public string updateddBy { get; set; } = string.Empty;
        public DateTime? updatedAt { get; set; }
        public string deleteBy { get; set; } = string.Empty;
        public DateTime? deleteAt { get; set; }
        public bool IsDeleted {get; set;} = false;
    }

}