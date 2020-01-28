using System;

namespace AbstarctInterface
{
    class User
    {
        public void Atack()
        {
            if (this.Weapon == null) 
            {
                Console.WriteLine("No weapon.");
                return;
            }

            this.Weapon.Shoot();
        }

        public IWeapon Weapon { get; set; }
    }
}