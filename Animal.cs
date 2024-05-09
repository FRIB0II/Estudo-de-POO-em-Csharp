namespace Animais
{   
    // Classe base (pai);
    class Animal
    {   
        // Criando uma classe com com a palavra chave "virtual" para fazer uso do polimorfismo e sobrescrita de método;
        public virtual void SomAnimal()
        {
            Console.WriteLine("O animal produz um som.");
        }
    }

    class Porco : Animal
    {   
        // Criando uma classe com a palavra chave "override" para fazer uso do polimorfismo e sobrescrita de método;
        public override void SomAnimal()
        {
            Console.WriteLine("O porco faz: wee wee");
        }
    }

    class Cachorro : Animal
    {   
        // Criando uma classe com a palavra chave "override" para fazer uso do polimorfismo e sobrescrita de método;
        public override void SomAnimal()
        {
            Console.WriteLine("O cachorro faz: bow wow");
        }
    }
}