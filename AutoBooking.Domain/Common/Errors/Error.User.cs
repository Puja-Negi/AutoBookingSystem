
using ErrorOr;

namespace AutoBooking.Domain.Common.Errors
{
    public static partial class Errors
    {
        public static class User
        {
            public static Error DuplicatePhoneNumber => Error.Conflict(
                code: "User.DuplicatePhoneNumber",
                description: "PhoneNumber is already in use.");
        }
    }
}