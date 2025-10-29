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
            if (name == null)
            {
                this.name = "Игрок";
            }
            else
            {
                this.name = name;
            }
        }
        public void CurrentBalance()
        {
            Console.WriteLine(coinsInWallet);
        }
    }
}
