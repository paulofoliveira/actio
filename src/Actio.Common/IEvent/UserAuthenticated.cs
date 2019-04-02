namespace Actio.Common.IEvent
{
    public class UserAuthenticated : IEvent
    {
        protected UserAuthenticated() { }

        public UserAuthenticated(string email)
        {
            Email = email;
        }

        public string Email { get; }
    }
}
