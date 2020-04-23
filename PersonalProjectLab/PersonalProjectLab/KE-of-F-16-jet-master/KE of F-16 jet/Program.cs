using System;

namespace KE_of_F_16_jet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kinetic Energy of F-16 for a sonic boom");

            int velocity;
            double KE;
            string input = "";

            // Get the jet velocity from the user
            Console.WriteLine("Enter the jet velocity");

            input = Console.ReadLine();

            velocity = int.Parse(input);

            // Calculate the Kinetic Energy

            KE = (9280 * velocity * velocity) / 2;

            Console.WriteLine("The Kinetic Energy is " + KE);
        }
    }
}
