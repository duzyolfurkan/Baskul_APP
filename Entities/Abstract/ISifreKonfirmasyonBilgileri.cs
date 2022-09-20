using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface ISifreKonfirmasyonBilgileri
    {
        int SifreID { get; set;}
        string MailAdresi { get; set; }
        int Sifre { get; set; }

    }
}
