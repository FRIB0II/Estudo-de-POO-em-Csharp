namespace Animais
{   
    // Classe base (pai);
    // Criando uma classe com com a palavra chave "abstract" para fazer uso de uma classe abstrata;
    abstract class AnimalAbstrato
    {   
        // Método abstrato
        public abstract void SomAnimal();

        // Método regular
        public void Dormir()
        {
            Console.WriteLine("Zzz");
        }

    }

    class PorcoAbstrato : AnimalAbstrato
    {   
        /* Criando uma classe com a palavra chave "override" para fazer da sobrescrita de método.
         O que vai definir o corpo do método SomAnimal() da classe base abstrata;*/
        public override void SomAnimal()
        {
            Console.WriteLine("O porco faz: wee wee");
        }
    }
}