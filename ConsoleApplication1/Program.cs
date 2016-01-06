using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            NewNumber getNewNumber = new NewNumber();
            Game game = new Game();

            Console.WriteLine("Play a game of High/Low, guesse if the next didget vill be higher, lower or the same as the previous one.");
            int next = getNewNumber.newInt();
            //int random = getNewNumber.newInt(5, 10); // Ur samma klass kan vi oxå sätta ett bestämt värde.
            int previous;

            while (play)
            {
                Console.WriteLine("You've got number: {0}, is the next one Higher(h) or Lower(l)?", next);
                previous = next;
                string answer = Console.ReadLine();
                next = getNewNumber.newInt();
                Console.Clear();
                Console.WriteLine("The new number is {0}.", next);
                game.Evaluate(previous, next, answer);
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