using System;
using System.Collections.Generic;
using System.Text;
using RPS.Objects;

namespace RPS.Interfaces
{
    interface ILogic
    {
        void Play(byte param1, byte param2);
        void Play(string param1, string param2);
        void GetLastMatchWinner();
        void GetTotalWinner();
        byte Traduct(string play);
        string Traduct(byte play);
        byte SetWinner(Player p1, Player p2);
    }
}
