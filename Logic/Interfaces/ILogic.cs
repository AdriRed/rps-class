using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interfaces
{
    interface ILogic
    {
        void Play(byte param1, byte param2);
        void Play(string param1, string param2);
        void GetLastMatchWinner();
        void GetTotalWinner();
        byte Traduct(string play);
        string Traduct(byte play);
        byte SetWinner(byte p1, byte p2);
    }
}
