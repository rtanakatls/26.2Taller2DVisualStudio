using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D262
{
    internal class Player
    {
        private string name;
        private int id;
        private int hp;
        private int level;

        private int experience;

        public Player(string name,int experience, int hp, int level)
        {
            this.name = name;
            this.experience = experience;
            this.hp = hp;
            this.level = level;
        }

    }
}
