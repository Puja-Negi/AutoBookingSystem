namespace AutoBooking.Contracts.Authentication.Admin
{
    public record AdminRegisterRequest(
       string FirstName,
       string LastName,
       string Email,
       string PhoneNumber,
       bool IsAdmin,
       string Password);
}
