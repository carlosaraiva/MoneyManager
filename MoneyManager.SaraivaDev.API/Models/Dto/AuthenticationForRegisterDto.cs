using System.ComponentModel.DataAnnotations;

namespace MoneyManager.SaraivaDev.API.Models.Dto
{
    public class AuthenticationForRegisterDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [RegularExpression(@"^\S*$")]
        public string Username { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, MaxLength(20)]
        [RegularExpression(@"^\d+$")]
        public string TaxNumber { get; set; }
        [Required, MaxLength(20)]
        public string IdNumber { get; set; }

    }
}
