namespace CleanArchitecture.Presantation.Contracts.Authentication
{
    public record LoginRequest(
        string Email,
        string Password
    );
}
