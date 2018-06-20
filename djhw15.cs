using System;

namespace ConsoleApp2
{
    class djhw15
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Electric Daisy Carnival!");
            Console.ReadKey();
            Console.WriteLine("Come join us on the Kinetic Field... where we can dance under the electric sky.");
            Console.ReadKey();
            Console.Write("Which dj do you want to see first? [Enter Name]");
            string odj = Console.ReadLine();
            Console.ReadKey();
            opener opp = new opener(odj, 1, 1000);
            Console.WriteLine("You better get there soon. {0} has an estimated {1} fans attending.", odj, opp._fans);
            Console.ReadKey();
            Console.WriteLine("They have a very tight schedule. They will only play for {0} hour before the next dj comes on.", opp._hour);
            Console.ReadKey();
            Console.Write("Guess who is going to go on stage after {0}? [Enter Name]", odj);
            string MyDj = Console.ReadLine();
            Console.ReadKey();
            headliner me = new headliner(MyDj, 3, 2000, "fireworks");
            Console.WriteLine("Yes! {0} is going to have {1} incorporated into their set.", MyDj, me._production);
            Console.ReadKey();
            Console.WriteLine("The {0} are going to help bring {1} fans to the stage.", me._production, me._fans);
            Console.ReadKey();
            Console.WriteLine("{0} is going to play for a longer time than {1} and will be on stage for {2} hours.", MyDj, odj, me._hour);
            Console.ReadKey();
            Console.WriteLine("HAVE FUN INSOMNIACS!");
            Console.ReadKey();


        }
    }
}
