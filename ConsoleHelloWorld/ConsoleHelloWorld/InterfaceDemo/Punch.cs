using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld.InterfaceDemo
{
    internal class Punch : IAttack, IWeapon
    {
        public IAttack GetAttack()
        {
            return this; // Punch is child of IAttack
        }

        public float GetDamage()
        {
            return 60;
        }

        public float GetRange()
        {
            return 1;
        }
    }
}
