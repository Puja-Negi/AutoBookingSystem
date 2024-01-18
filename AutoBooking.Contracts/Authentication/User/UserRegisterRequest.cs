namespace AutoBooking.Contracts.Authentication.User
{
    public record UserRegisterRequest(
       string FirstName,
       string LastName,
       string PhoneNumber);
}
