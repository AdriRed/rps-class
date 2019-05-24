using System;
using System.Collections.Generic;
using System.Text;
using RPS.Objects;

namespace RPS.Interfaces
{
    interface IRound
    {
        void SetWinner();
        Player GetWinner();
    }
}
