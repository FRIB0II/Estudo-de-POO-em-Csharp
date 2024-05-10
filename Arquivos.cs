using System.Security.Cryptography.X509Certificates;

namespace Arquivos
{
    class MeuArquivo
    {
        public string textoEscrito;
        public string nomeDoArquivo;

        public MeuArquivo(string texto, string arquivo)
        {
            textoEscrito = texto;
            nomeDoArquivo = arquivo;

            File.WriteAllText(nomeDoArquivo, textoEscrito);
        }

        public string LerArquivo(string nomeDoArquivo)
        {
            string leitura = File.ReadAllText(nomeDoArquivo);
            return leitura;
        }
    }
}