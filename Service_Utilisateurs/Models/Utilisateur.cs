using System.ComponentModel.DataAnnotations;

namespace Service_Utilisateurs.Models
{
    public class Utilisateur
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public string Telephone { get; set; }
        public DateTime DateInscription { get; set; } = DateTime.UtcNow;
    }
}
