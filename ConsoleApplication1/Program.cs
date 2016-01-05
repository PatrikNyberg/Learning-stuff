using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Console.ReadLine() != "n")
            {
                Random random = new Random();
                int previous = random.Next(1,100);
                Console.WriteLine(previous);
                Console.WriteLine("Higher(h) or Lower(l)?");
                string answer = Console.ReadLine();
                if (answer == "h")
                {
                    int next = random.Next(1, 100);
                    Console.WriteLine(next);
                    if (next > previous)
                    {
                        Console.WriteLine("You win! Press Enter to play again");
                    }
                    else if (next == previous)
                    {
                        Console.WriteLine("It's a Draw! Press Enter to play again");
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                        Console.WriteLine("Play again? (y/n)");
                        Console.ReadLine();
                    }
                  }

                if (answer == "l")
                {
                    int next = random.Next(1, 100);
                    Console.WriteLine(next);
                    if (next < previous)
                    {
                        Console.WriteLine("You win! Press Enter to play again");
                    }
                    else if (next == previous)
                    {
                        Console.WriteLine("It's a Draw! Press Enter to play again");
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                        Console.WriteLine("Play again? (y/n)");
                        Console.ReadLine();
                    }
                }
                if (answer == "d")
                {
                    int next = random.Next(1, 100);
                    Console.WriteLine(next);
                    if (next == previous)
                    {
                        Console.WriteLine("YOU WIN JACKPOT!!! Please stop playing now.. or press Enter");
                    }
                    else
                    {
                        Console.WriteLine("You gambled but obviously you lost!");
                        Console.WriteLine("Play again? (y/n)");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}


//Check metod kollar att svar är korrekt (while som fortsätter sålänge som det är korrekt)
//High returnerar alla värden över random
//Low returnerar alla värden under random


//while (correct != "Wrong")
//{
//    Random random = new Random(1 - 10);
//    Console.WriteLine(random);
//    Console.WriteLine("Higher or Lower?");
//    Console.ReadLine();

//}