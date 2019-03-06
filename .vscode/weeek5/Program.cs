using System;

namespace weeek5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("numero uno plz");
            int numerouno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("numero deus plz");
            int numerodeus = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("operator how can i help you");
            string operatIon = Console.ReadLine();

            if(operatIon == "+")
            {
                Console.WriteLine(AddNumbers(numerouno, numerodeus));
            }

            else if(operatIon == "-")
            {
                int diff = SubtractNumbers(numerouno, numerodeus);
                Console.WriteLine(diff);
            }

            else
            {
                Console.WriteLine("error 404 lol gotti");
            }
        }

        public static int AddNumbers(int numerouno, int  numerodeus)
        {
            return numerouno + numerodeus;
        }

        public static int SubtractNumbers(int cheeze, int chese)
        {
            return cheeze - chese;
        }
    }   
}
