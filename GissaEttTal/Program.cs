internal class Program
{


    private static void Main(string[] args)
    {
        var r = new Random();
        var lowscoreList = new List<string>();
        Spela();

        while(true)
        {
            Console.WriteLine("1: Spela igen!");
            Console.WriteLine("2: Visa low score lista!");
            Console.WriteLine("3: Avsluta!");
            var choice = Console.ReadKey(true);

            switch (choice.KeyChar)
            {

                case '1':
                    Spela();
                    break;

                case '2':
                    lowscore(lowscoreList);
                    break;

                case '3':
                    Console.WriteLine("Tack för den här gången!");
                    return;
            }
           
        }
       

        void Spela()
        {
            Console.WriteLine("Gissa ett tal mellan 1 och 100");
            var HemligtTal = r.Next(1, 101);
            var guess = 0;
            int Tal = 0;
            do
            {
                guess++;
                bool isNumber = false;
                while(isNumber == false)
                {
                    Console.Write("Gissning " + guess + ": ");
                    string strNr = Console.ReadLine() ?? string.Empty;
                   
                    if(int.TryParse(strNr, out Tal))
                    {
                        isNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Du kan bara skriva tal med siffror!");
                    }
                }


                if (Tal > HemligtTal)
                {
                    Console.WriteLine("Talet är lägre!");
                }
                else if (Tal < HemligtTal)
                {
                    Console.WriteLine("Talet är högre!");
                }

                if (Tal == HemligtTal)
                {
                    Console.WriteLine("Du gissade rätt på " + guess + " försök");
                    var date = DateTime.Now.ToString("MM/dd/yyyy");
                    //Här blir det att lägga till i lowscorelistan i framtiden
                    return;
                }
            } while (Tal != HemligtTal);


        }

        void lowscore(List<string> lowscorelist)
        {
            Console.WriteLine("Lista på resultat");
            foreach (var Tal in lowscorelist)
                Console.WriteLine($"\n{Tal}");
        }
    }
}