namespace ConsoleApp1
{
    internal class Program
    {
        public static int counter = 0;
        static void Main(string[] args)
        {
            var rand = new Random();
            int num = rand.Next(0,101);
            var guessedNumber = 0;
            bool isDone = false;
            

            while(!isDone)
            {
                Console.WriteLine("Spróbuj zgadnąć wylosowaną liczbę:\n");
                try
                {
                    guessedNumber = int.Parse(Console.ReadLine());
                    counter++;
                    isDone = CheckNumber(guessedNumber, num);
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Podano złą wartość.\n\n");
                    continue;
                }
                
            }

        }

        static bool CheckNumber(int numberToCheck, int desiredNumber)
        {
            if (numberToCheck < desiredNumber)
            {
                Console.WriteLine("Wybrana liczba jest mniejsza od poszukiwanej.\n\n");
                return false;
            }
            else if(numberToCheck > desiredNumber) 
            {
                Console.WriteLine("Wybrana liczba jest wieksza od poszukiwanej.\n\n");
                return false;
            }
            else
            {
                Console.WriteLine($"Odgadłeś szukaną liczbę!!!  ({desiredNumber})\nLiczba prób: {counter}");
                return true;

            }
        }


    }
}