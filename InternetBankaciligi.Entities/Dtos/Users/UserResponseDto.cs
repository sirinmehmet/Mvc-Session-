using InternetBankaciligi.Entities.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBankaciligi.Entities.Dtos.Users
{
    public class UserResponseDto : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MailAddress { get; set; }
        public string Username { get; set; }
    }
}
