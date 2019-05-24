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

            Player player1 = new Player("Adri");
            Player player2 = new Player("Alberto");

            Game game = new Game(player1, player2);

            game.NewRound("Rock", "Scissors");
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());


            player1.SetMove("Paper"); player2.SetMove("Paper");
            game.NewRound(player1, player2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());

            player1.SetMove("Paper"); player2.SetMove("Rock");
            game.NewRound(player1, player2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());

            player1.SetMove("Paper"); player2.SetMove("Rock");
            game.NewRound(player1, player2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());

            player1.SetMove("Paper"); player2.SetMove("Rock");
            game.NewRound(player1, player2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());

            player1.SetMove("Paper"); player2.SetMove("Rock");
            game.NewRound(player1, player2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());

            player1.SetMove("Paper"); player2.SetMove("Rock");
            game.NewRound(player1, player2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());

            player1.SetMove("Paper"); player2.SetMove("Rock");
            game.NewRound(player1, player2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());

            player1.SetMove("Paper"); player2.SetMove("Rock");
            game.NewRound(player1, player2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());

            player1.SetMove("Paper"); player2.SetMove("Rock");
            game.NewRound(player1, player2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());

            player1.SetMove("Paper"); player2.SetMove("Rock");
            game.NewRound(player1, player2);
            Console.WriteLine("RESULT " + game.actualRound.GetResult());

            Console.WriteLine(game.GetState());



        }

    }
}