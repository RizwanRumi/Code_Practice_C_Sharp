using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    internal class Party
    {
        public void Cheering(int points)
        {
            Console.WriteLine($"Wooohoo! You finally achieve the highest {points} points.");
        }
    }
}
