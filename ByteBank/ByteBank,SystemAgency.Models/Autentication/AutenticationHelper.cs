using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank_SystemAgency.Models
{
    internal class AutenticationHelper
    {
        public bool ComparePassword(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;
        }
    }
}
