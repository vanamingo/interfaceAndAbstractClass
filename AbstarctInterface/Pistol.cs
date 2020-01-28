namespace AbstarctInterface
{
    class Pistol : BulletWeapon
    {
        public Pistol()
        {
            Bullets = 10;
        }

        protected override int BulletsPerShoot
        {
            get { return 1; }
        }
    
        protected override string GetSound()
        {
            return "Bah";
        }
    }
}