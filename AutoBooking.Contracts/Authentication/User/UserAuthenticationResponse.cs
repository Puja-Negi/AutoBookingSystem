namespace AutoBooking.Contracts.Authentication.User
{
    public record AuthenticationResponse(
       Guid UserId,
       string FirstName,
       string LastName,
       string PhoneNumber,
       string Token);
}
