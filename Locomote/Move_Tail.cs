using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_n_Booster_Gobler.Locomote
{
    internal class Move_Tail
    {
        private const int Scope_Diameter = 11;
        private const int max = 30;
        //private static bool iStarted = false;
        private static int x_recentHead = 0;
        private static int y_recentHead = 0;
        public static void New_Tail_Position(
            ref int x_prevHead,
            ref int y_prevHead,
            ref bool iStarted)
        {
            if(iStarted is false)
            {
                x_recentHead = x_prevHead;
                y_recentHead = y_prevHead;
            }
            else
            {
                Console.Write("T");
            }

            iStarted = true;
           
        }
    }
}
