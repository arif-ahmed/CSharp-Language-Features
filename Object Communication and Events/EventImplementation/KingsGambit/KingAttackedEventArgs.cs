using System;
using System.Collections.Generic;
using System.Text;

namespace KingsGambit
{
    public class KingAttackedEventArgs: EventArgs
    {
        public KingAttackedEventArgs(string kingName)
        {
            KingName = kingName;
        }
        public string KingName { get; }
    }
}
