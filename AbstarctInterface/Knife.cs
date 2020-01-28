using System;

namespace AbstarctInterface
{
    class Knife : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("==={-------------->");
        }
    }
}