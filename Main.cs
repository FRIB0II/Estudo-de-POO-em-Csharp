using Eletrodomestico;
using Veículos;
using Animais;
using Enumeradores;
using Arquivos;

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

            Console.WriteLine("");

            // Exemplo de abstração;
            
            PorcoAbstrato porcoAbstrato = new PorcoAbstrato();
            porcoAbstrato.Dormir();
            porcoAbstrato.SomAnimal();

            Console.WriteLine("");

            // Exemplo de interface;

            PorcoImplementacao porcoImplementacao = new PorcoImplementacao();
            porcoImplementacao.SomAnimal();

            Console.WriteLine("");

            // Exemplo de enumeradores

            IntensidadeDoPedal minhaIntensidade = IntensidadeDoPedal.Intenso;
            switch(minhaIntensidade)
            {
                case IntensidadeDoPedal.Baixo:
                    Console.WriteLine("Sua intensidade é baixa.");
                    break;

                case IntensidadeDoPedal.Médio:
                    Console.WriteLine("Sua intensidade é média.");
                    break;
                
                case IntensidadeDoPedal.Intenso:
                    Console.WriteLine("Você é intenso!");
                    break;
            }

            int numeroDaIntensidade = (int) IntensidadeDoPedal.Médio;

            Console.WriteLine($"O nível da sua intensidade é {numeroDaIntensidade}");

            Console.WriteLine("");

            // Exemplo de leitura e criação de arquivos

            Console.Write("Escreva seu texto: ");
            string textoEntrada = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Digite o nome do arquivo onde irá salva-lo: ");
            string arquivoEntrada = Console.ReadLine();

            MeuArquivo meuObjArquivo1 = new MeuArquivo(textoEntrada, arquivoEntrada);

            Console.WriteLine("");

            Console.Write("Digite o nome do arquivo que você quer ler: ");
            string leituraArquivo = Console.ReadLine();

            string retornoLeitura = meuObjArquivo1.LerArquivo(leituraArquivo);

            Console.WriteLine("");
            
            Console.WriteLine($"O texto do seu arquivo é: {retornoLeitura}");  

            Console.ReadKey();
            Console.WriteLine("");
        }
    }
}