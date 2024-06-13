using Bil_App;

    Run();
    void Run()
    {
        while (true)
        {
            var games = new Games();
            Console.Clear();
            Console.WriteLine("1 for første bilspill, 2 for andre bilspill.");
            string input = Console.ReadLine();

            if (input == "1") games.firstCarGame();
            else if (input == "2") games.secondCarGame();
            else if (input != "1" && input != "2") continue;

            Console.WriteLine("Trykk 1 for å begynne på nytt. Hva som helst annet for å avslutte");
            string input2 = Console.ReadLine();
            if (input2 != "1") break;
        }
    }



   
