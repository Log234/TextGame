using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame
{
    class Character : Targetable
    {
        public string Name { get; private set; }
        public int Level { get; private set; }

        public void Attack(Targetable target)
        {
            
        }

        public void Examine(GameObject item)
        {

        }
    }
}
