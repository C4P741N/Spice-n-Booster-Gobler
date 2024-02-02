using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_n_Booster_Gobler.Locomote
{
    internal class Move_Head
    {
        private const int Scope_Diameter = 11;
        private const int max = 30;
        private static int stored_map_y = 0;
        private static int stored_map_x = 0;
        public static bool isStarted = false;
        public static void New_Head_Position(
            int[,,] scanned_section,
            int Hy, int Hx,
            ref char[][] map)
        {
            for (int y = 0; y < Scope_Diameter; y++)
            {
                for (int x = 0; x < Scope_Diameter; x++)
                {
                    int map_y = scanned_section[y, 0, x];
                    int map_x = scanned_section[y, 1, x];

                    if (map_y < 0)
                    {
                        map_y += max;

                        if (map_y == max)
                        {
                            map_y = 0;
                        }
                    }
                    if (map_x < 0)
                    {
                        map_x += max;

                        if (map_x == max)
                        {
                            map_x = 0;
                        }
                    }

                    char position_value = map[map_y][map_x];

                    if (map_y == stored_map_y && map_x == stored_map_x)
                    {
                        Move_Tail.New_Tail_Position(ref map_x, ref map_y, ref isStarted);

                        if (isStarted)
                        {
                            continue;
                        }
                    }

                    if (map_y == Hy && map_x == Hx)
                    {
                        if (position_value == 'B' || position_value == '$')
                        {
                            map[map_y][map_x] = '*';
                        }
                        if (position_value == '#')
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("You disintegrated your caterpillar !");
                            return;
                        }

                        Console.Write("H");
                        stored_map_x = map_x;
                        stored_map_y = map_y;
                        isStarted = true;
                        continue;
                    }

                    Console.Write(position_value);
                }
                Console.WriteLine();
            }
        }
    }
}
