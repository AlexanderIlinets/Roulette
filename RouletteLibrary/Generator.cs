using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLibrary
{
    public class Generator
    {
        public Generator()
        {
            ChooseColor();
            ChooseIndex();
        }

        public int color;
        public int index;

        public void ChooseColor()
        {
            Random rand = new Random();
            color = rand.Next(1, 3);
        }

        public void ChooseIndex()
        {
            Random rand = new Random();
            index = rand.Next(0, 19);
        }
    }
}
