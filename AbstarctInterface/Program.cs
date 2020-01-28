using System;

namespace AbstarctInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.Atack();
            user.Atack();
            user.Atack();

            Console.WriteLine("--------------------Knife------------------");

            user.Weapon = new Knife();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();  
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();  
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();  
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();  
            

            Console.WriteLine("--------------------Pistol------------------");

            user.Weapon = new Pistol();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();


            Console.WriteLine("--------------------LazerPistol------------------");

            user.Weapon = new LazerPistol();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();
            user.Atack();

            Console.ReadLine();
        }
    }
}
