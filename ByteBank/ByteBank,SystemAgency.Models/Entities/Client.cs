namespace ByteBank.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Profession { get; set; }

        public override bool Equals(object obj)
        {
            Client outherClient = obj as Client;

            if (outherClient == null)
            {
                return false;
            }

            return CPF == outherClient.CPF;
        }
    }
}
