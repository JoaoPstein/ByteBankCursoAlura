using System;

namespace ByteBank.SystemAgency
{
    public class URLArgumentValueExtractor
    {
        public string URL { get; }
        private readonly string _arguments;

        public URLArgumentValueExtractor(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("O argumento URL não pode ser vazio", nameof(url));
            }

            int interrogacao = url.IndexOf('?');
            _arguments.Substring(interrogacao + 1);

            URL = url;
        }

        public string GetValue(string nameParam)
        {
            nameParam = nameParam.ToUpper();
            string argumentoEmCaixaAlta = _arguments.ToUpper();

            string termo = nameParam + "=";
            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo);

            string result = _arguments.Substring(indiceTermo + termo.Length);
            int indiceEComercial = result.IndexOf('&');

            if (indiceEComercial == -1)
            {
                return result;
            }

            return result.Remove(indiceEComercial);
        }
    }
}
