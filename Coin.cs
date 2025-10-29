using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks2
{
    internal class Coin
    {
        private Random random = new Random();
        public int nominal;
        public Coin()
        {
            this.nominal = random.Next(1, 100);
        }
    }
}
