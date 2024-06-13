using Bil_App;

    Run();
    void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1 for første bilspill, 2 for andre bilspill.");
            string input = Console.ReadLine();

            if (input == "1") new Game1().firstCarGame();
            else if (input == "2") new Game2().secondCarGame();
            else if (input != "1" && input != "2") continue;
           
            Console.WriteLine("Trykk 1 for å begynne på nytt. Hva som helst annet for å avslutte");
            if (Console.ReadLine() != "1") break;
        }
    }



   
