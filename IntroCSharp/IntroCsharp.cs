namespace IntroCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            do{
                Console.WriteLine("Escolha um Exercicio: ");
                Console.WriteLine("[1] Exercicio 6");
                Console.WriteLine("[2] Exercicio 16");
                Console.WriteLine("[3] Exercicio 19");
                Console.WriteLine("[4] Exercicio 26");
                Console.WriteLine("[5] Exercicio 27");
                Console.WriteLine("[6] Exercicio Extra");
                Console.WriteLine("[7] Sair");
                op = Convert.ToInt32(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        Exercicios.Ex6();
                        break;
                    case 2:
                        Exercicios.Ex16();
                        break;
                    case 3:
                        Exercicios.Ex19();
                        break;
                    case 4:
                        Exercicios.Ex26();
                        break;
                    case 5:
                        Exercicios.Ex27();
                        break;
                    case 6:
                        Console.WriteLine("Isenção por motivos de kahoot :P");
                        break;
                    case 7:
                        Console.WriteLine("Finalizando Programa. . .");
                        break;
                    default:
                        Console.WriteLine("Opcao Invalida!");
                        break;
                }
            }while(op != 7);
            Console.WriteLine("Programa Finalizado!");
        }
    }
}