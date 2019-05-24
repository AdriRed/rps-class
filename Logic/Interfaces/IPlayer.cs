using System;
using System.Collections.Generic;
using System.Text;

namespace RPS.Interfaces
{
    interface IPlayer
    {
        void SetMove(string smove);
        void SetMove(sbyte move);
        void AddPoint();
    }
}
