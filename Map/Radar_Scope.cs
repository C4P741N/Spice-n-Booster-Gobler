using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_n_Booster_Gobler.Map
{
    internal class Radar_Scope
    {
        private const int Scope_Radius = 5;
        private const int Scope_Diameter = 11;
        public static int[,,] Generate_Scanned_Sections(int Hx, int Hy)
        {
            
            int ZeroY = Hy - Scope_Radius;
            //int count = 0;

            int[,,] Radar_3d = new int[Scope_Diameter, 2, Scope_Diameter];

            //int[,,] arr3D = new int[2, 2, 3] 
            //{ 
            //    { 
            //        { 24, 24, 24 }, 
            //        { -5, -4, -3 } 
            //    }, 
            //    { 
            //        { 7, 8, 9 }, 
            //        { 10, 11, 12 } 
            //    } 
            //};

            for (int y = 0; y < Scope_Diameter; y++)
            {
                if (ZeroY == 30)
                {
                    ZeroY = 0;
                }

                int ZeroX = Hx - Scope_Radius;

                for (int x = 0; x < Scope_Diameter; x++)
                {
                    if (ZeroX == 30)
                    {
                        ZeroX = 0;
                    }

                    Radar_3d[y, 0, x] = ZeroY;
                    Radar_3d[y, 1, x] = ZeroX;

                    ZeroX++;
                }

                ZeroY++;
            }

            //24.-5  24.0  24.5
            //29.-5  29.0  29.5
            //-4.-5  -4.0  -4.5

            return Radar_3d;
        }
    }
}
