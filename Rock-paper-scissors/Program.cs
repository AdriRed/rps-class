using System;
using Logic;

namespace RPS.Front
{
    class Program
    {
        static void Main()
        {
            LogicRPS logic = new LogicRPS();

            //"Rock"
            //"Paper"
            //"Scissors"

            //1
            logic.Play(0, 1);
            //2
            logic.Play("Rock", "Paper");
            //3
            logic.Play("Scissors", "Paper");
            //4
            logic.Play("Paper", "Rock");
            //5
            logic.Play(2, 2);
            //6
            logic.Play("Rock", "Scissors");
            //7
            logic.Play("Rock", "Rock");
            //8
            logic.Play(2, 0);
            //9
            logic.Play(1, 0);
            //10
            logic.Play("Rock", "Rock");

            //logic.GetTotalWinner();

            Console.ReadKey();
        }
    }
}
