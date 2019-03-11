using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLibrary
{
    public class Bets
    {
        public Bets(int color, int index, int number, string WinningNumber)
        {
            if (index == 0)
            {
                IndNum(WinningNumber);
            }
            else
            {
                IndNum(WinningNumber);
                EvenOdd(number);
                RedBlack(color);
                HighLow(index);
                Dozens(index);
                Columns(number);
                Street(number);
                DoubleRows(number);
                Split(number);
                Corner(number);
            }
        }

        public string IndNum(string WinningNumber)
        {
            string winningStatement = $"You won {WinningNumber}, retrive your payout at 1:35 odds";
            Console.WriteLine(winningStatement);
            return winningStatement;
        }

        public string EvenOdd(int number)
        {
            string winningStatement;

            if (number % 2 == 0)
            {
                winningStatement = "You won evens, retrive your payout at 1:1 odds";
            }
            else
            {
                winningStatement = "You won odds, retrive your payout at 1:1 odds";
            }

            Console.WriteLine(winningStatement);
            return winningStatement;
        }

        public string RedBlack(int color)
        {
            string winningStatement;

            if (color > 1)
            {
                winningStatement = "You won red, retrive your payout at 1:1 odds";
            }
            else
            {
                winningStatement = "You won black, retrive your payout at 1:1 odds";
            }

            Console.WriteLine(winningStatement);
            return winningStatement;
        }

        public string HighLow(int index)
        {
            string winningStatement;

            if (index <= 9)
            {
                winningStatement = "You won Low Numbers 1 - 18 , retrive your payout at 1:1 odds";
            }
            else
            {
                winningStatement = "You won High Numbers 19 - 36 , retrive your payout at 1:1 odds";
            }

            Console.WriteLine(winningStatement);
            return winningStatement;
        }

        public string Dozens(int index)
        {
            string winningStatement;
            if (index <= 6)
            {
                winningStatement = "You won 1st twelve 1 - 12 , retrive your payout at 1:2 odds";
            }
            else if (index >= 7 && index <= 13)
            {
                winningStatement = "You won 2nd twelve 13 - 24 , retrive your payout at 1:2 odds";
            }
            else
            {
                winningStatement = "You won 3rd twelve 25 - 36 , retrive your payout at 1:2 odds";
            }

            Console.WriteLine(winningStatement);
            return winningStatement;
        }

        int column;
        public string Columns(int number)
        {
            Arrays instArray = new Arrays();
            string winningStatement;

            if (number % 3 == 0)
            {
                winningStatement = "You won 3rd column, retrive your payout at 1:2 odds";
                column = 3;
            }
            else if (number % 3 == 1)
            {
                winningStatement = "You won 1st column, retrive your payout at 1:2 odds";
                column = 1;
            }
            else
            {
                winningStatement = "You won 2nd column, retrive your payout at 1:2 odds";
                column = 2;
            }

            Console.WriteLine(winningStatement);
            return winningStatement;
        }

        public string Street(int number)
        {
            string winningStatement;

            if (column == 1)
            {
                winningStatement = $"You won street numbers {number} {number + 1} {number + 2}, retrive your payout at 1:11 odds";
            }
            else if (column == 2)
            {
                winningStatement = $"You won street numbers {number - 1} {number} {number + 1}, retrive your payout at 1:11 odds";
            }
            else
            {
                winningStatement = $"You won street numbers {number - 2 } {number - 1} {number}, retrive your payout at 1:11 odds";
            }

            Console.WriteLine(winningStatement);
            return winningStatement;
        }

        public string DoubleRows(int number)
        {
            string winningStatement;

            if (column == 1)
            {
                if (number == 1)
                {
                    winningStatement = $"You won double rows {number} {number + 1} {number + 2} and {number + 3} {number + 4} {number + 5}, retrive your payout at 1:5 odds";
                }
                else if (number == 34)
                {
                    winningStatement = $"You won double rows {number - 3} {number - 2} {number - 1} and {number} {number + 1} {number + 2}, retrive your payout at 1:5 odds";
                }
                else
                {
                    winningStatement = $"You won double rows {number - 3} {number - 2} {number - 1} and {number} {number + 1} {number + 2}   " +
                        $"or   {number} {number + 1} {number + 2} and {number + 3} {number + 4} {number + 5}, retrive your payout at 1:5 odds";
                }

                Console.WriteLine(winningStatement);
                return winningStatement;
            }
            else
            {
                winningStatement = string.Empty;
                return winningStatement;
            }
        }

        public string Split(int number)
        {
            string winningStatement;

            if (column == 1)
            {
                if (number == 1)
                {
                    winningStatement = $"You won split numbers {number} and {number + 1}" +
                    $"   or   {number} and {number + 3}, retrive your payout at 1:17 odds";
                }
                else if (number == 34)
                {
                    winningStatement = $"You won split numbers {number - 3} and {number}   or   {number} and {number + 1}" +
                    $", retrive your payout at 1:17 odds";
                }
                else
                {
                    winningStatement = $"You won split numbers {number - 3} and {number}   or   {number} and {number + 1}" +
                    $"   or   {number} and {number + 3}, retrive your payout at 1:17 odds";
                }
            }
            else if (column == 2)
            {
                if (number == 2)
                {
                    winningStatement = $"You won split numbers {number - 1} and {number}   or   {number} and {number + 1}" +
                    $"   or   {number} and {number + 3}, retrive your payout at 1:17 odds";
                }
                else if (number == 35)
                {
                    winningStatement = $"You won split numbers {number - 3} and {number}   or   {number - 1} and {number}" +
                    $"   or   {number} and {number + 1}, retrive your payout at 1:17 odds";
                }
                else
                {
                    winningStatement = $"You won split numbers {number - 3} and {number}   or   {number - 1} and {number}" +
                    $" or   {number} and {number + 1}   or   {number} and {number + 3}, retrive your payout at 1:17 odds";
                }
            }
            else
            {
                if (number == 3)
                {
                    winningStatement = $"You won split numbers {number - 1} and {number}" +
                    $"   or   {number} and {number + 3}, retrive your payout at 1:17 odds";
                }
                else if (number == 36)
                {
                    winningStatement = $"You won split numbers {number - 3} and {number}   or   {number - 1} and {number}" +
                    $", retrive your payout at 1:17 odds";
                }
                else
                {
                    winningStatement = $"You won split numbers {number - 3} and {number}   or   {number - 1} and {number}" +
                    $"   or   {number} and  {number + 3}, retrive your payout at 1:17 odds";
                }
            }

            Console.WriteLine(winningStatement);
            return winningStatement;
        }
        
        public string Corner(int number)
        {
            string winningStatement;

            if (column == 1)
            {
                if (number == 1)
                {
                    winningStatement = $"You won corner numbers {number}, {number + 1}" +
                    $", {number + 3}, and {number + 4}, retrive your payout at 1:8 odds";
                }
                else if (number == 34)
                {
                    winningStatement = $"You won split numbers {number - 3}, {number - 2}, {number} and {number + 1}" +
                    $", retrive your payout at 1:8 odds";
                }
                else
                {
                    winningStatement = $"You won corner numbers  {number - 3}, {number - 2}, {number} and {number + 1}  or   {number}, {number + 1}" +
                    $", {number + 3}, and {number + 4}, retrive your payout at 1:8 odds";
                }
            }
            else if (column == 2)
            {
                if (number == 2)
                {
                    winningStatement = $"You won corner numbers  {number - 1}, {number}, {number + 2} and {number + 3}  or   {number}, {number + 1}" +
                    $", {number + 3}, and {number + 4}, retrive your payout at 1:8 odds";
                }
                else if (number == 35)
                {
                    winningStatement = $"You won corner numbers  {number - 4}, {number - 3}, {number - 1} and {number}  or   {number - 3}, {number - 2}" +
                    $", {number}, and {number + 1}, retrive your payout at 1:8 odds";
                }
                else
                {
                    winningStatement = $"You won corner numbers  {number - 4}, {number - 3}, {number - 1} and {number}  or   {number - 3}, {number - 2}" +
                    $", {number}, and {number + 1}   or   {number - 1}, {number}, {number + 2} and {number + 3}   " +
                    $"or   {number}, {number + 1}, {number + 3} and {number + 4}, retrive your payout at 1:8 odds";
                }
            }
            else
            {
                if (number == 3)
                {
                    winningStatement = $"You won corner numbers {number - 1}, {number}" +
                    $", {number + 2}, and {number + 3}, retrive your payout at 1:8 odds";
                }
                else if (number == 36)
                {
                    winningStatement = $"You won split numbers {number - 4}, {number - 3}, {number - 1} and {number}" +
                    $", retrive your payout at 1:8 odds";
                }
                else
                {
                    winningStatement = $"You won corner numbers  {number - 4}, {number - 3}, {number - 1} and {number}  or   {number - 1}, {number}" +
                    $", {number + 2}, and {number + 3}, retrive your payout at 1:8 odds";
                }
            }

            Console.WriteLine(winningStatement);
            return winningStatement;
        }
    }
}
