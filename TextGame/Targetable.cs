using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame
{
    abstract class Targetable: GameObject
    {
        public int Health { get; set; }

        public void TakeDamage(int amount)
        {

        }

        public void Heal(int amount)
        {

        }
    }
}
