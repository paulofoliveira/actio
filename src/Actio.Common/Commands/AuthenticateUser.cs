namespace Actio.Common.Commands
{
    public class AuthenticateUser : ICommand
    {
        public AuthenticateUser()
        {
        }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
