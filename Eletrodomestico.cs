namespace Eletrodomestico
{
    // Criando a classe base (pai);
    class Eletrodomestico
    {
        public string marca = "Eletrolux";
        public string som = "bipi bipi bipi";
    }

    // Criando a classe derivada (filha ou herdeira);
    class Geladeira : Eletrodomestico
    {
        public string nomeDoModelo = "Geladeira duas portas"; 
    }
}