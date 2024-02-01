﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_n_Booster_Gobler.Map
{
    internal class Map_Co_ordinates
    {
        public static string Lets_First_Look_At_The_Map()
        {
            char[][] map = {
                ['$','*','*','*','*','*','*','*','*','*','$','*','*','*','*','*','*','*','*','*','*','$','*','*','*','*','*','*','*','*'],
                ['*','*','*','$','*','*','*','*','*','*','*','B','*','*','*','*','*','*','*','*','*','*','*','*','*','#','*','*','*','*'],
                ['*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','#','*','*','*','*','*'],
                ['*','*','*','#','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*'],
                ['*','*','$','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','#','*'],
                ['$','$','*','*','*','#','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*'],
                ['*','*','*','*','*','*','*','*','*','*','*','*','*','*','$','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*'],
                ['*','*','*','*','*','*','*','*','*','*','$','*','*','*','*','*','*','*','*','*','$','*','*','*','*','*','#','*','*','*'],
                ['*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','$','*','*','*','*','*','*','*','$','*'],
                ['*','*','*','*','*','*','*','*','*','#','*','*','*','*','$','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*'],
                ['*','*','B','*','*','*','*','*','*','*','*','*','$','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*'],
                ['*','*','*','*','*','*','*','*','*','*','*','*','*','$','$','*','*','*','*','B','*','*','*','*','*','*','*','*','*','*'],
                ['*','*','*','*','$','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','B'],
                ['*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','#','*','*','*','*','*','*','*'],
                ['*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','$','*','*','*','B','*','*'],
                ['*','*','*','*','*','*','*','*','$','*','*','*','$','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*'],
                ['*','*','*','*','*','*','*','*','*','*','*','*','$','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*'],
                ['*','*','*','*','*','*','*','*','*','$','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*'],
                ['*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','#','*','*','*','*','*','*','*','*'],
                ['*','*','*','*','*','*','*','$','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*'],
                ['*','#','*','*','*','$','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','#','*','*','*','*','*','*','*'],
                ['*','*','*','*','#','*','*','*','*','$','*','*','*','*','$','*','*','*','*','*','*','*','*','B','*','*','*','*','*','*'],
                ['*','*','*','#','*','*','$','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','$','*','*'],
                ['*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','#','*','*','*','*','*','*','*','*','*','*','*','*','*','*'],
                ['*','*','*','*','*','*','*','*','*','*','*','$','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*'],
                ['*','*','*','*','B','*','*','*','*','#','*','*','*','*','*','*','B','*','*','*','*','*','*','*','*','*','*','*','*','*'],
                ['*','*','*','$','*','*','*','*','*','*','*','*','*','*','*','*','*','*','*','$','*','*','*','*','*','B','*','*','*','*'],
                ['*','*','*','*','*','*','*','*','*','*','$','*','*','*','*','*','*','*','*','*','#','*','$','*','*','*','*','*','*','*'],
                ['*','*','*','*','*','*','*','*','*','*','*','*','*','*','#','*','*','*','*','*','*','*','*','B','*','*','*','*','*','*'],
                ['s','*','*','*','*','*','*','*','*','*','*','$','*','*','*','*','*','*','*','*','*','#','*','B','*','*','*','*','*','*'],
            };

            //Legend
            //* Empty 1x1 square meter of land
            //$ Spice to be collected
            //B Booster
            //# Obstacles
            //s Starting position of the worm HT

            return "";
        }
    }
}