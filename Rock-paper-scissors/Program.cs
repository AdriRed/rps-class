using System;
using RPS.Objects;

namespace RPS.Front
{
    class Program
    {
        static void Main()
        {
            //P1 = PLAYER 1
            //P2 = PLAYER 2

            Player p1 = new Player("Adri");
            Player p2 = new Player("Alberto");

            Game game = new Game(p1, p2);

            game.NewRound("Rock", "Scissors");
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());


            p1.SetMove("Paper"); p2.SetMove("Paper");
            game.NewRound(p1, p2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());

            p1.SetMove("Paper"); p2.SetMove("Rock");
            game.NewRound(p1, p2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());

            p1.SetMove("Paper"); p2.SetMove("Rock");
            game.NewRound(p1, p2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());

            p1.SetMove("Paper"); p2.SetMove("Rock");
            game.NewRound(p1, p2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());

            p1.SetMove("Paper"); p2.SetMove("Rock");
            game.NewRound(p1, p2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());

            p1.SetMove("Paper"); p2.SetMove("Rock");
            game.NewRound(p1, p2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());

            p1.SetMove("Paper"); p2.SetMove("Rock");
            game.NewRound(p1, p2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());

            p1.SetMove("Paper"); p2.SetMove("Rock");
            game.NewRound(p1, p2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());

            p1.SetMove("Paper"); p2.SetMove("Rock");
            game.NewRound(p1, p2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());

            p1.SetMove("Paper"); p2.SetMove("Rock");
            game.NewRound(p1, p2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());



        }

    }
}