using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D262
{
    internal class Person
    {
        private string name;
        private int damage;
        private int hp;
        public string Name { get { return name; } } 


        public string GetName()
        {
            return name;
        }

        public void TakeDamage(int damage)
        {
            hp -= damage;
        }
    }
}
