using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLibrary
{
    public class RouletteNumber
    {
        //Default Constructor
        public RouletteNumber()
        {

        }

        //Test Constructor
        public RouletteNumber(int color, int index)
        {
            Console.WriteLine(GetNumber(color, index));
        }

        public int Number;
        public string WinningNumber;
        Arrays instArray = new Arrays();        
        public string GetNumber(int color, int index)
        {
            if (color > 1)
            {
                if (index == 0)
                {
                    WinningNumber = "Zero";
                }
                else
                {
                    Number = instArray.RedNumbers[index];
                    WinningNumber = $"Red {Number}";
                }
                return WinningNumber;
            }
            else
            {
                if (index == 0)
                {
                    WinningNumber = "DoubleZero";
                }
                else
                {
                    Number = instArray.BlackNumbers[index];
                    WinningNumber = $"Black {Number}";
                }
                return WinningNumber;
            }           
        }
    }
}
