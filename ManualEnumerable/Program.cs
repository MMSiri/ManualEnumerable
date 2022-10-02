using System;

namespace ManualEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            var sports = new BetterSportSequence();
            foreach (var sport in sports)
            {
                Console.WriteLine(sport);
            }

            var sequence = new SportCollection();
            Console.WriteLine(sequence[3]);

            foreach (var i in new PowersOfTwo())
            {
                Console.WriteLine(i);
            }
        }
    }
}
