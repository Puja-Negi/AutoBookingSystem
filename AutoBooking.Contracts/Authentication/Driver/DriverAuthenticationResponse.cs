namespace AutoBooking.Contracts.Authentication.Driver
{
    public record DriverAuthenticationResponse(
       Guid UserId,
       string FirstName,
       string LastName,
       string PhoneNumber,
       string LicenseNumber,
       string DriverLocation,
       bool AvailabilityStatus,
       bool IsDriver,
       string Token);
}
