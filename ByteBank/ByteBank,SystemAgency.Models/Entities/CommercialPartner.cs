using ByteBank_SystemAgency.Models.Autentication;

namespace ByteBank_SystemAgency.Models.Entities
{
    public class CommercialPartner : IAutentication
    {
        private AutenticationHelper _autenticationHelper = new AutenticationHelper();
        public string Password { get; set; }

        public bool Autentication(string password)
        {
            return _autenticationHelper.ComparePassword(Password, password);
        }
    }
}
