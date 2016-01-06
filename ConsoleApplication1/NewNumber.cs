using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NewNumber
    {

        private Random random;

        public NewNumber() // Konstruktor, skapar upp random objektet som vi använder i klassen.
        {
            this.random = new Random();
        }

        public int newInt() // skickar tillbaka ett nummer mellan 1 och 100. kallas på med newInt();
        { 
            return random.Next(1, 100);
        }

        public int newInt(int x, int y) // pollymorphism, skickar tillbaka ett nummer mellan x och y. ex. newInt(1,6); get ett nummer mellan 1 ooch 6
        {
            return random.Next(x, y);
        }
    }
}
