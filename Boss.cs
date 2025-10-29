using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks2
{
    
    internal class Boss
    {
        private Random random = new Random();
        public int type;
        public int hp;
        public int attack;
        public int magicalPenetration;
        public int physicalPenetration;
        public int magicalDefence;
        public int physicalDefence;
        public Boss()
        {
            this.type = random.Next(1,4);
            if (type == 1)
            {
                this.hp = 60;
                this.attack = 20;
                this.physicalPenetration = 2;
                this.physicalDefence = 10;
                this.magicalDefence = 0;
            }
            else
            {
                this.hp = 100;
                this.attack = 10;
                this.physicalPenetration = 1;
                this.physicalDefence = 5;
                this.magicalDefence = 15;
            }
            
        }
        public int Attack(Player player)
        {
            if (this.attack * physicalPenetration - player.physicalDefence > 0)
            {
                return this.attack * physicalPenetration - player.physicalDefence;
            }
            else
            {
                return 0;
            }
        }
        public int StrongAttack(Player player)
        {
            if (2*this.attack * physicalPenetration - player.physicalDefence > 0)
            {
                return 2*this.attack * physicalPenetration - player.physicalDefence;
            }
            else
            {
                return 0;
            }
        }
        public int SelectAttack(int type, ref Player player)
        {
            if (type == 1)
            {
                return Attack(player);
            }
            else
            {
                return StrongAttack(player);
            }
        }
    }
}
