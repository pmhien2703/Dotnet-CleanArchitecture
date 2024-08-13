namespace CleanArchitecture.Presantation.Contracts.Authentication
{
    public record LoginRequest(
        string FirstName,
        string LastName
    );
}
