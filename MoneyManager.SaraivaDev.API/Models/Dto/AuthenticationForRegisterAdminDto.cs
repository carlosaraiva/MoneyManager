namespace MoneyManager.SaraivaDev.API.Models.Dto
{
    public class AuthenticationForRegisterAdminDto
    {
        public string Username { get; set; }
        public string Email { get; internal set; }
        public string Password { get; internal set; }
    }
}
