using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBankaciligi.Entities.Concrete
{
    // VERİTABANI İLE UYGULAMAMIZ ARASINDA TABLO GİBİ OBJELERİ OLUŞTURMAMIZI SAĞLAYAN BİR KÖPRÜDÜR.
    // dbo.Users KARŞILIĞI BU SINIFTIR.
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MailAddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
