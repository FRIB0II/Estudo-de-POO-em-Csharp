using Eletrodomestico;
using Veículos;
using Animais;

namespace Programa
{   
    class Programa
    {
        // static pertence a classe, e não a seus objetos; 
        static void Main(string[] args)
        {   
            Console.Clear();

            // Instanciando um novo objeto da classe Carro;
            // Os parâmetros do construtor devem ser enviados durante a instância do objeto;

            Carro carro = new Carro("Corsa", "Azul", 350, "Ele é antigo.");
            carro.Chassi = "9BWHE21JX24060831";
            Console.WriteLine($"O {carro.modelo} é {carro.cor} e sua velocidade máxima é {carro.velocidadeMaxima}Km/h. {carro.descricao}");
            Console.WriteLine($"O chassi do {carro.modelo} é {carro.Chassi}");

            Console.WriteLine("");

            Carro carro2 = new Carro("Opala", "Preto", 250, "Ele é novo.");
            Console.WriteLine($"O {carro2.modelo} é {carro2.cor} e sua velocidade máxima é {carro2.velocidadeMaxima}Km/h. {carro2.descricao}");
            carro2.Chassi = "4MORF95IX03857158";
            Console.WriteLine($"O chassi do {carro2.modelo} é {carro2.Chassi}");

            Console.WriteLine("");
            
            // Exemplo de herança;

            Geladeira geladeira = new Geladeira();
            Console.WriteLine($"A marca da geladeira é {geladeira.marca}. O som que ele produz é {geladeira.som}. E seu modelo é a {geladeira.nomeDoModelo}");

            Console.WriteLine("");
            
            // Exemplo de herança e polimorfismo;

            Animal animal = new Animal();
            Porco porco = new Porco();
            Cachorro cachorro = new Cachorro();

            animal.SomAnimal();
            porco.SomAnimal();
            cachorro.SomAnimal();
            
            PorcoAbstrato porcoAbstrato = new PorcoAbstrato();
            porcoAbstrato.Dormir();
            porcoAbstrato.SomAnimal();

            Console.ReadKey();
            Console.WriteLine("");
        }
    }
}