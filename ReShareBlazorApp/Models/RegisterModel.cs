using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace ReShareBlazorApp.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Podaj nazwe użytkownika!")]
        [MinLength(8,ErrorMessage ="nazwa uzytkownika musi miec conajmniej 8 znakow")]
        [MaxLength(24,ErrorMessage ="nazwa uzytkownika jest za długa")]
        public string Username { get; set; } = "";
        [Required(ErrorMessage = "Podaj adres email!")]
        [EmailAddress(ErrorMessage ="Nieprawidłowy adres email")]
        public string Email { get; set; } = "";
        [Required(ErrorMessage = "Podaj hasło!")]
        [MinLength(8,ErrorMessage ="haslo musi meic conajmniej 8 znakow")]
        public string Password { get; set; } = "";
        [Required(ErrorMessage = "Potwierdz hasło!")]
        [Compare(nameof(Password),ErrorMessage ="hasla nie sa takie same")]
        public string ConfirmPassword { get; set; }
        [Range(typeof(bool), "true", "true", ErrorMessage = "Musisz zaakceptować regulamin!")]
        public bool AcceptTerms { get; set; }
    }
}
