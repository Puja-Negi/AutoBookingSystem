namespace AutoBooking.Contracts.Authentication.Admin
{
    public record AdminAuthenticationResponse(
       Guid UserId,
       string FirstName,
       string LastName,
       string Email,
       string PhoneNumber,
       bool IsAdmin,
       string Token);
}
