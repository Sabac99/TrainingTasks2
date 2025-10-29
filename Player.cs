using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks2
{
    internal class Player
    {
        public string name ;
        public int coinsInWallet;
        public Player()
        {
            this.name = "Игрок";
        }
        public Player(string name)
        {
            this.name = name;
        }
        public void CurrentBalance()
        {
            Console.WriteLine(coinsInWallet);
        }
    }
}
