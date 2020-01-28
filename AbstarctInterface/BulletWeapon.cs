using System;

namespace AbstarctInterface
{
    abstract class BulletWeapon : IWeapon
    {
        protected int Bullets { get; set; }
        protected abstract int BulletsPerShoot { get; }

        protected abstract string GetSound();
        public virtual void Shoot()
        {
            if (Bullets <= 0)
            {
                Console.WriteLine("Empty!");
                return;
            }

            Console.WriteLine(GetSound() + BulletsPerShoot);
            Bullets = Bullets - BulletsPerShoot;
        }
    }
}