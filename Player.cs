using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks2
{
    internal class Player
    {
        private string name;
        public List<int> coinWallet;
        public Player(string name)
        {
            this.name = name;
        }
        public void CheckCoinsInWallet()
        {
            for (int i = 0; i < coinWallet.Count; i++)
            {
                Console.Write(coinWallet[i]);
            }
        }
    }
}
