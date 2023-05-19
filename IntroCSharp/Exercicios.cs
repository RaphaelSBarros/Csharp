namespace IntroCsharp
{
    public class Exercicios
    {
        public static void Ex6()
        {
            Console.WriteLine("Digite a duracao do evento em segundos: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int h = input / 3600;
            input = input - h * 3600;

            int m = input / 60;
            input = input - m * 60;

            int s = input;

            Console.WriteLine("A duracao do evento em horas, minutos e segundo e de: "+ h +" horas, "+m+" minutos e "+s+" segundos.");
        }

        public static void Ex16()
        {
            Console.WriteLine("Digite seu CPF: ");
            int cpf = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o numero de dependentes: ");
            int dep = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor da sua renda mensal: ");
            int rm = Convert.ToInt32(Console.ReadLine());
            int sm = 1300;
            int desc = 5;

            rm = rm - (rm * ((dep*desc)/100));

            if(rm > (sm*2) && rm <= (sm*3)){
                Console.WriteLine("De acordo com a sua renda mensal voce sera taxado em 5% da sua renda em impostos!");
                Console.WriteLine("O valor do imposto sera de: "+rm*0.05);
            }else if(rm > (sm*3) && rm <= (sm*5)){
                Console.WriteLine("De acordo com a sua renda mensal voce sera taxado em 10% da sua renda em impostos!");
                Console.WriteLine("O valor do imposto sera de: "+rm*0.10);
            }else if(rm > (sm*5) && rm <= (sm*7)){
                Console.WriteLine("De acordo com a sua renda mensal voce sera taxado em 15% da sua renda em impostos!");
                Console.WriteLine("O valor do imposto sera de: "+ rm*0.15);
            }else if(rm > (sm*7)){
                Console.WriteLine("De acordo com a sua renda mensal voce sera taxado em 20% da sua renda em impostos!");
                Console.WriteLine("O valor do imposto sera de: "+rm*0.20);
            }else{
                Console.WriteLine("De acordo com a sua renda mensal voce esta ISENTO de impostos");
            }
        }

        public static void Ex19()
        {
            Console.WriteLine("Informe o valor do capital: ");
            int capital = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a porcentagem da taxa: ");
            double taxa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o tempo em dias: ");
            int dias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O valor do capital e de: "+capital);
            Console.WriteLine("Com uma taxa de: "+taxa+"% ao dia");
            Console.WriteLine("Valor dos juros: "+capital*((taxa/100)*dias));
            Console.WriteLine("Valor total do montante e de: "+(capital+(capital*((taxa/100)*dias))));
        }

        public static void Ex26()
        {
            double total = 0;
            Console.WriteLine("Informe o numero de pessoas: ");      
            int num = Convert.ToInt32(Console.ReadLine());
 
            double[] pessoas = new double[num];

            for(int i=0; i<num; i++){
                Console.WriteLine("Digite o peso da "+ (i+1) +"ª pessoa: ");
                pessoas[i] = Convert.ToDouble(Console.ReadLine());
                total += pessoas[i];
            }
            Console.WriteLine("O peso medio das "+num+" pessoas e: "+(total/num)+" kgs");
        }

        public static void Ex27()
        {
            int j = 0;
            double total = 0;
            do
            {
                double[] peso = new double[j+1];
                
                Console.WriteLine("Informe o seu peso (kgs): "); 
                peso[j] = Convert.ToDouble(Console.ReadLine());
                total += peso[j];
                j++;
            }while(total < 180);
            Console.WriteLine("A capacidade maxima foi atingida!");
        }
    }
}