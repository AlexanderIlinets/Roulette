using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouletteLibrary;

namespace RouletteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator instGen = new Generator();

            RouletteNumber num1 = new RouletteNumber(instGen.color,instGen.index);
            //RouletteNumber num1 = new RouletteNumber(2, 1);

            Bets instBet = new Bets(instGen.color, instGen.index, num1.Number, num1.WinningNumber);
        }
    }
}
