using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quasar_Again
{
    class Die
    {
        private int min;
        private int max;

        private Random rand = new Random();

        public Die()
        {
            min = 1;
            max = 6+1;
        }

        public Die(int min, int max)
        {
            this.min = min;
            this.max = max+1;
        }


        public int roll(){
            return rand.Next(min, max);
        }
    }
}
