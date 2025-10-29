using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks2
{
    internal class Player
    {
        public int hp;
        public int mana;
        public string playerClass;
        public int attack;
        private int magicalPenetration;
        private int physicalPenetration;
        public int physicalDefence;
        public Player(string playerClass)
        {
            switch (playerClass)
            {
                case "маг":
                    {
                        this.mana = 100;
                        this.playerClass = playerClass;
                        this.hp = 90;
                        this.attack = 20;
                        this.magicalPenetration = 3;
                        this.physicalPenetration = 1;
                        this.physicalDefence = 5;
                        break;
                    }
                case "воин":
                    {
                        this.mana = 20;
                        this.playerClass = playerClass;
                        this.hp = 100;
                        this.attack = 20;
                        this.magicalPenetration = 1;
                        this.physicalPenetration = 3;
                        this.physicalDefence = 10;
                        break;
                    }
                default:
                    {
                        this.mana = 0;
                        this.playerClass = "крестьянин";
                        this.hp = 200;
                        this.attack = 30;
                        this.magicalPenetration = 1;
                        this.physicalPenetration = 1;
                        this.physicalDefence = 5;
                        break;
                    }
            }
        }
        public int Attack(Boss boss)
        {
           if (this.attack * physicalPenetration - boss.physicalDefence > 0)
           {
               return this.attack * physicalPenetration - boss.physicalDefence;
           }
           else
           {
               return 0;
           }
               
        }
        public int MagicAttack(Boss boss)
        {
                if (this.mana >= 10)
                {
                    this.mana -= 10;

                    if( this.attack * magicalPenetration - boss.magicalDefence > 0)
                    {
                        return this.attack * magicalPenetration - boss.magicalDefence;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    Console.WriteLine("Недостаточно маны");
                    return 0;
                }
        }
    }
}
