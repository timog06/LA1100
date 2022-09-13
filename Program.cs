namespace GlückszahlGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            
            while (play == true)
            {
                try
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Wählen Sie einen Zahlenbereich:");
                    int diff = Convert.ToInt32(Console.ReadLine());

                    Random rnd = new Random();
                    int num = rnd.Next(1, diff);

                    Console.WriteLine("Schätzen Sie eine Zahl zwischen 1 und {0}: ", diff);
                    string guessstr = Console.ReadLine();
                    int guessint = Convert.ToInt32(guessstr);


                    while (num != guessint)
                    {
                        if (num < guessint && guessint <= diff && guessint >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ihre Zahl ist zu gross. ");
                        }
                        if (num > guessint && guessint <= diff && guessint >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ihre Zahl ist zu klein. ");
                        }
                        if (guessint > diff || guessint < 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Ihre Zahl ist ungültig. Bitte geben Sie eine gültige Zahl ein. ");
                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        guessint = Convert.ToInt32(Console.ReadLine());
                    }
                    if (guessint == num)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Bravo Sie haben die richtige Zahl erraten!");
                    }

                    Console.WriteLine("Wollen Sie nochmals spielen? [true/false]: ");
                    play = Convert.ToBoolean(Console.ReadLine());
                    Console.Clear();
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ungültige Eingabe.");
                    Console.WriteLine("Starten Sie von vorne.");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                }
            }
        }
    }
}

