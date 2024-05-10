namespace Animais
{
    // Criando uma interface;
    interface IAnimal
    {   
        // Método da interface (não possui um corpo)
        void SomAnimal();
    }

    class PorcoImplementacao : IAnimal
    {
        public void SomAnimal()
        {
            // O corpo do SomAnimal() é providenciado aqui;
            Console.WriteLine("O porco faz: wee wee");
        }
    }
}

/*

Notas sobre interfaces:

    .

*/