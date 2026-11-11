namespace Bedingungen2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aufgabe1();

            Console.WriteLine("------------------------------");

            Aufgabe2();
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
    }
}
