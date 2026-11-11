namespace Bedingungen2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aufgabe1();

            Console.WriteLine("------------------------------");

            Aufgabe2();

            Console.WriteLine("------------------------------------");

            Aufgabe3();
        }

        static void Aufgabe1()
        {
            try
            {
                Console.Write("Gib eine Zahl ein: ");
                string input = Console.ReadLine();

                int zahl = int.Parse(input);

                Console.WriteLine($"Die Zahl die de eingegeben hast: {zahl}");
                Console.WriteLine($"Das doppelte: {zahl * 2}");

            } catch (Exception ex)
            {
                Console.WriteLine("Das ist keine gültige Zahl");
            }
        }

        static void Aufgabe2()
        {
            Console.Write("Gib dein Alter ein: ");
            int input = int.Parse(Console.ReadLine());

            if (input >= 18)
            {
                Console.WriteLine("Zutritt gewährt, viel spaß");
            } else
            {
                Console.WriteLine("Du bist noch zu jung. Zutritt verweigert.");
            }
        }

        static void Aufgabe3()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Write("Gib eine Zahl von 0 - 100 ein: ");
                int input = int.Parse(Console.ReadLine());
                
                if (input > 100)
                {
                    Console.WriteLine("Zahl zu hoch, probieren sie es nochmal");
                } else if (input < 0)
                {
                    Console.WriteLine("Zahl ist unter 0, probieren sie es nochmal");
                }
                else if (input >= 90)
                {
                    Console.WriteLine("Note: Sehr gut");
                    break;
                } else if (input >= 75)
                {
                    Console.WriteLine("Note: gut");
                    break;
                } 
                else if (input >= 50)
                {
                    Console.WriteLine("Note: Befriedigend");
                    break;
                } else
                {
                    Console.WriteLine("Durchgefallen");
                    break;
                }
            }
        }
    }
}
