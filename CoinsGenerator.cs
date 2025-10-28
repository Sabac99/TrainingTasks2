using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks2
{
    internal class CoinsGenerator
    {
        Random random = new Random();
        private int coin;
        public int GenerateCoin()
        {
            coin = random.Next(1, 101);
            return coin;
        }
    }
}
