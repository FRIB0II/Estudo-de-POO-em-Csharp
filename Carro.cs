namespace Veículos
{
    class Carro
    {   
        // Campos da classe ficam fora de um método;

        public string modelo;
        public string cor;
        public int velocidadeMaxima;
        public string descricao;
        // private string chassi;

        // Propriedades. É através delas que poderemos atualizar e usar o campo privado "chassi";
        // Mais longo
        // public string Chassi
        // {
        //     get { return chassi; }
        //     set { chassi = value; }
        // }

        //Mais curto
        public string Chassi { get; set; }

        /*Método construtor. Não possui valor de retorno.
         Cria os objetos quando é chamado. Nome do construtor deve ser igual ao nome da Classe.*/

        //Passa um parâmetro para o construtor.

        public Carro(string nomeDoModelo, string nomeDaCor, int numeroDaVelocidade, string textoDescricao)
        {
            modelo = nomeDoModelo;
            cor = nomeDaCor;
            velocidadeMaxima = numeroDaVelocidade;
            descricao = textoDescricao; 
        }
    }
}