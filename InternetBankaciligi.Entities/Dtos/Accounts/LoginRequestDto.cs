using InternetBankaciligi.Entities.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBankaciligi.Entities.Dtos.Accounts
{
    public class LoginRequestDto : BaseDto
    {
        public string MailAddress { get; set; }
        public string Password { get; set; }
    }
}
