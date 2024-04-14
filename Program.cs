namespace ProjetoPilha
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nInício main");
            TADPilha pilha = new TADPilha();
            //pilha.Push(5);
            //pilha.Push(11);
            //pilha.Push(3);
            //pilha.ImprimirPilha();
            //pilha.Push(20);
            //pilha.Push(5);
            //pilha.ImprimirPilha();
            //Console.WriteLine($"Elemento de código {pilha.Pop()} removido.");
            //Console.WriteLine($"Elemento de código {pilha.Pop()} removido.");
            //pilha.ImprimirPilha();

            do
            {
                try
                {
                    Console.WriteLine("O que deseja fazer? \n1- Empilhar elemento. \n2- Desempilhar elemento. \n3- Imprimir pilha.");
                    int selecao = int.Parse(Console.ReadLine());
                    switch (selecao){
                        case 1:
                            Console.WriteLine("\nDigite o código do elemento a ser empilhado:");
                            pilha.Push(int.Parse(Console.ReadLine()));
                            break;
                        case 2:
                            pilha.Pop();
                            Console.WriteLine("\nElemento removido.");
                            break;
                        case 3:
                            pilha.ImprimirPilha();
                            break;
                    }
                    Console.WriteLine("\nDeseja realizar outra operação? \n1- Sim. \n2- Não.");
                    selecao = int.Parse(Console.ReadLine());
                    if(selecao == 2)
                    {
                        break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("\nErro:");
                    Console.WriteLine(e.Message);
                    Console.WriteLine("\n");
                }
            } while (true);
            

            Console.WriteLine("\nFim main");


        }
    }
}