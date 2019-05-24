using System;
using RPS.Objects;

namespace RPS.Front
{
    class Program
    {
        static void Main()
        {
            Player p1 = new Player("Adri");
            Player p2 = new Player("Alberto");

            Game g = new Game(p1, p2);

            g.NewRound("Rock", "Scissors");
            Console.WriteLine("RESULT " + g.actualRound.GetResult());

            Console.WriteLine(g.GetState());

            p1.SetMove("Paper"); p2.SetMove("Paper");
            g.NewRound(p1, p2);
            Console.WriteLine("RESULT " + g.actualRound.GetResult());

            Console.WriteLine(g.GetState());

            p1.SetMove("Paper"); p2.SetMove("Rock");
            g.NewRound(p1, p2);
            Console.WriteLine("RESULT " + g.actualRound.GetResult());

            Console.WriteLine(g.GetState());
            
        }

    }
}
