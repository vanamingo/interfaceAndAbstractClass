using System;

namespace AbstarctInterface
{
    class LazerPistol : BulletWeapon
    {
        public LazerPistol()
        {
            Bullets = 10;
        }

        protected override int BulletsPerShoot
        {
            get { return 2; }
        }

        protected override string GetSound()
        {
            return "Bzliu";
        }

        public override void Shoot()
        {
            base.Shoot();
            if (Bullets <= 0)
            {
                Console.WriteLine("New battery!!!");
                Bullets = 10;
            }
        }
    }
}