using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul2
{
    class Program
    {
        static int Fin(char u)
        {
            u = Char.ToLower(u);
            switch(u)
            {
                default:
                    return 0;
                case 'a':
                    return 1;
                case 'b':
                    return 2;
                case 'c':
                    return 3;
                case 'd':
                    return 4;
                case 'e':
                    return 5;
                case 'f':
                    return 6;
                case 'g':
                    return 7;
                case 'h':
                    return 8;
                case 'i':
                    return 9;
                case 'j':
                    return 10;
                case 'k':
                    return 11;
                case 'l':
                    return 12;
                case 'm':
                    return 13;
                case 'n':
                    return 14;
                case 'o':
                    return 15;
                case 'p':
                    return 16;
                case 'q':
                    return 17;
                case 'r':
                    return 18;
                case 's':
                    return 19;
                case 't':
                    return 20;
                case 'u':
                    return 21;
                case 'v':
                    return 22;
                case 'w':
                    return 23;
                case 'x':
                    return 24;
                case 'y':
                    return 25;
                case 'z':
                    return 26;
            }
            
        }
        static void Main(string[] args)
        {
            string[ , ] mat = new string[80,80];
            Console.WriteLine("Introduceti cuvinte separate de ,");
            string lista = Console.ReadLine();
            string[] data = lista.Split(',');
            int i = 0,f;
            int n = data.Length;

            int nl, nc, j, k=0,l=0;
            for (j = 0; j < 50; j++)
            {
                mat[j,0] = "1";
            }
            for(j=0;j<n;j++)
            {
                f = Fin(data[j][0]);
                i = Convert.ToInt32(mat[f,0]);
                mat[f, 0] = Convert.ToString(i + 1);
                mat[f, i] = data[j];
            }
            Console.Write("Dupa sortare alfabetica\n");
            for (j = 0; j <= 50; j++)
            {
                for (k = 1; k <= 50; k++)
                {
                    if (mat[j, k] != null)
                    {
                        if (l != j)
                        {
                            Console.WriteLine("\n");
                            l = j;
                        }
                        Console.Write(mat[j, k] + ", ");
                    }
                }
            }
            //Console.Write(data[0]);
            /*for ( j = 0; j < 50; j++)
            {
                for ( k = 0; k < 50; k++)
                {
                    mat[j,k] = data[i++];

                    if (i == n)
                    {
                        break;
                    }
                }
                if (i == n)
                {
                    break;
                }
            }

            nl = j;
            nc = k;
            string mc = "Mucho";
            //mc = char.ToLower(mc[0]) + mc.Substring(1);
            int f;
            f=Fin(mc[0]);
            Console.WriteLine("T E S T :" + mc[0]+" Cu numarul " + f);

            for (j = 0; j <= nl; j++)
            {
                for (k = 0; k <=nc; k++)
                {
                    Console.Write(mat[j,k]+", ");
                }
            }
            Console.WriteLine("Dupa organizare alfabetica\n");
            for (j = 0; j <= 50; j++)
            {
                for (k = 0; k <= 50; k++)
                {
                    f = Fin(mat[j,k][0]);
                    if(f!=0)
                    {

                        for (l = k; l < 50; l++)
                        {
                            mat[j][l] = mat[j][l + 1];
                        }
                    }
                }
            }

            */
            Console.ReadLine();
        }
        
    }
}
