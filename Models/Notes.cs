using System.ComponentModel.DataAnnotations;

namespace at.Models
{
    public class Note
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória"), StringLength(300)]
        public string Description { get; set; }
    }
}
