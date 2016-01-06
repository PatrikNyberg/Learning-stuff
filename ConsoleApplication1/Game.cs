using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Game
    {
        private string continuePlay;

        public void Evaluate(int previous, int next, string answer)
        {
            if (answer == "h")
            {
                if (next > previous)
                {
                    Console.WriteLine("You win!");
                }
                else if (next == previous)
                {
                    Console.WriteLine("It's a Draw!");
                }
                else
                {
                    Console.WriteLine("You lose!");
                    Console.WriteLine("Play again? (y/n)");
                    continuePlay = Console.ReadLine();
                    this.Continue(continuePlay);
                }
            }

            if (answer == "l")
            {
                if (next < previous)
                {
                    Console.WriteLine("You win!");
                }
                else if (next == previous)
                {
                    Console.WriteLine("It's a Draw!");
                }
                else
                {
                    Console.WriteLine("You lose!");
                    Console.WriteLine("Play again? (y/n)");
                    continuePlay = Console.ReadLine();
                    this.Continue(continuePlay);
                }
            }
            if (answer == "d")
            {
                if (next == previous)
                {
                    Console.WriteLine("YOU WIN JACKPOT!!! Please stop playing now..");
                }
                else
                {
                    Console.WriteLine("You gambled but obviously you lost!");
                    Console.WriteLine("Play again? (y/n)");
                    continuePlay = Console.ReadLine();
                    this.Continue(continuePlay);
                }
            }
        }

        public bool Continue(string continuePlay)
        {
            Console.Clear();
            if (continuePlay.ToLower() == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
