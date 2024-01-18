namespace AutoBooking.Contracts.Authentication.Driver
{
    public record DriverRegisterRequest(
       string FirstName,
       string LastName,
       string PhoneNumber,
       string LicenseNumber,
       string DriverLocation,
       bool AvailabilityStatus,
       bool IsDriver
       );
}
