using InternetBankaciligi.Entities.Dtos.Base;
using InternetBankaciligi.Entities.Dtos.Users;

namespace InternetBankaciligi.Entities.Dtos.Accounts
{
    public class LoginResponseDto : BaseDto
    {
        public bool Success { get; set; }
        public UserResponseDto User { get; set; }
    }
}
