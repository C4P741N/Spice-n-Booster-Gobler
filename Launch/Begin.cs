using Spice_n_Booster_Gobler.Locomote;
using Spice_n_Booster_Gobler.Map;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_n_Booster_Gobler.Launch
{
    internal class Begin
    {
        private static int caterpillat_y_position = 29;
        private static int caterpillat_x_position = 0;
        private const int max = 30;
        private const int max_index = max -1;
        private const int Scope_Diameter = 11;
        public static void Lets_Catch_Them_All()
        {

            bool Continue = true, x_fromPositive = false, y_fromPositive = false;
            char[][] map = Map_Co_ordinates.Lets_Look_At_The_Map();

            int Hx = 0, Hy = 29; //Starting position

            while (Continue)
            {
                int[,,] scanned_section = Radar_Scope.Generate_Scanned_Sections(Hx, Hy);

                Move_Head.New_Head_Position(scanned_section, Hy, Hx, ref map);

                Console.Write("Continue ? Y or N : ");
                string continue_command = Console.ReadLine() ?? "";
                Continue = continue_command == "Y";

                while (Continue is false && continue_command != "N" )
                {
                    Console.Write("Invalid value press Y to continue or N to exit : ");
                    continue_command = Console.ReadLine() ?? "";
                    Continue = continue_command == "Y";
                }


                if (Continue)
                {
                    bool command_caterpillar = true;
                    while (command_caterpillar)
                    {

                        Console.WriteLine();
                        Console.Write("Input command to the great Caterpilar : ");
                        string direction_command = Console.ReadLine() ?? "";

                        while (string.IsNullOrEmpty(direction_command))
                        {
                            Console.WriteLine("Invalid command");
                        }

                        //int[,] array = new int[30, 30];

                        int numericValue = 0;

                        try
                        {
                            numericValue = int.Parse(direction_command.Substring(1));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Caterpillar does not understand, try imputing a valid command this time");
                            continue;
                        }

                        switch (direction_command[0])
                        {
                            case 'U':
                                if (Hy == 0 && y_fromPositive) Hy = 30;

                                y_fromPositive = false;
                                Hy -= numericValue;
                                command_caterpillar = false;
                                break;
                            case 'R':
                                Hx += numericValue;
                                command_caterpillar = false;
                                break;
                            case 'D':
                                //if (Hy == 0 && y_fromPositive) Hy = 30;

                                Hy += numericValue;
                                command_caterpillar = false;
                                break;
                            case 'L':
                                if (Hx == 0 && x_fromPositive) Hx = 30;

                                x_fromPositive = false;

                                Hx -= numericValue;
                                command_caterpillar = false;
                                break;
                            default:
                                Console.WriteLine("Caterpillar does not understand, try imputing a valid command this time");
                                break;
                        } 

                        if(Hy == 30)
                        {
                            Hy = 0;
                            y_fromPositive = true;
                        }
                        //if (Hy == -30)
                        //{
                        //    Hy = 0;
                        //    y_fromPositive = false;
                        //}
                        if (Hx == 30)
                        {
                            x_fromPositive = true;
                            Hx = 0;
                        }
                        //if (Hx == 30)
                        //{
                        //    x_fromPositive = false;
                        //    Hx = 0;
                        //}
                    }
                }
            }
        }
    }
}