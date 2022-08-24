using System;

namespace Calculator.ConsoleCalculator
{
    class Program
    {
        
        static void Main()
        {
            Console.WriteLine("Kalkulator wykonuje podstawowe działania na dwóch liczbach");
            while (true)
            {
                try
                {                               

                    Console.Write("Podaj 1 liczbę: ");
                    var num1 = GetInput();

                    Console.WriteLine("Wybierz działanie \n + dodawanie \n - odejmowanie \n * mnożenie \n / dzielenie \n Wybór: ");
                    var operation = Console.ReadLine();

                    Console.Write("Podaj 2 liczbę: ");
                    var num2 = GetInput();

                    var result = Calculate(num1, num2, operation);
                    Console.WriteLine("Twój wynik to: " + Math.Round(result, 2));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            

        }
        public static double GetInput()
        {
            if (!double.TryParse(Console.ReadLine(), out double input))
                throw new Exception("Podana wartośc nie jest liczbą");
            return input;
        }


        private static double Calculate(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                     
                case "-":
                    return num1 - num2;
                     
                case "*":
                    return num1 * num2;
                     
                case "/":
                    if (num2 == 0)
                    {
                        throw new Exception("Nie można dzielić przez 0");
                    }
                    else
                    {
                        return num1 / num2;
                    }
                     

                default:
                    throw new Exception("Błędna operacja");
            }           
        }
    }




}