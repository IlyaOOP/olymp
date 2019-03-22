using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hord
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader txR = Console.In;
            TextWriter txW = Console.Out;

            string input = txR.ReadLine();

            string[] inputarr = input.Split(' ');

            string[] koord = new string[Convert.ToInt32(inputarr[1])];

            for(int i=0; i< Convert.ToInt32(inputarr[1]); i++)
            {
                koord[i] = txR.ReadLine();
            }

            for(int i = 0; i< Convert.ToInt32(inputarr[1]); i++)
            {
                bool flag = true;
                string[] point_Arr = koord[i].Split(' ');
                int xord1_A = Convert.ToInt32(point_Arr[0]);
                int xord1_B = Convert.ToInt32(point_Arr[1]);
                int xord2_A = Convert.ToInt32(point_Arr[2]);
                int xord2_B = Convert.ToInt32(point_Arr[3]);

                if (xord2_A > xord1_A && xord2_A < xord1_B)
                {
                    if (xord2_B > xord1_A && xord2_B < xord1_B)
                    {
                        txW.WriteLine("NO");
                    }
                    else flag = false;
                }
                else if (xord2_A < xord1_A || xord2_A > xord1_B)
                {
                    if (xord2_B < xord1_A || xord2_B > xord1_B)
                    {
                        if (!(xord1_A == xord2_A || xord1_A == xord2_B || xord1_B == xord2_A || xord1_B == xord2_B))
                        {
                            txW.WriteLine("NO");
                        }
                        else flag = false;
                    }
                    else flag = false;
                }
                if(flag == false)
                {
                    txW.WriteLine("YES");
                }
            }
        }
    }
}
