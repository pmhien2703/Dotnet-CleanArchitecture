namespace CleanArchitecture.Application.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationResult Login(string email, string password)
        {
            return new AuthenticationResult(Guid.NewGuid(),"first name","last name",email, password);
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            return new AuthenticationResult(Guid.NewGuid(), firstName, lastName, email, password);

        }
    }
}
