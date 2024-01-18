namespace AutoBooking.Contracts.Authentication.Admin
{
    public record AdminLoginRequest(
       string Email,
       string Password);
}
