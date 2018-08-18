using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int asis, prim, trap, ef;
            double efin;
            Console.WriteLine("SISTEMA DE CALIFICACIONES O&M");
            Console.WriteLine("ASISTENCIA");
            asis = int.Parse(Console.ReadLine());
            Console.WriteLine("EXAMEN PARCIAL");
            prim = int.Parse(Console.ReadLine());
            Console.WriteLine("TRABAJO PRACTICO");
            trap = int.Parse(Console.ReadLine());
            Console.WriteLine("EXAMEN FINAL");
            ef = int.Parse(Console.ReadLine());
            efin = asis + prim + trap + ef;
            Console.WriteLine("Nota final" + efin);

            if(efin >= 90)
            {
                Console.WriteLine("A aprobado");
            }
            else if (efin >= 80)
            {
                Console.WriteLine("B aprobado");
            }
            else if (efin >= 75)
            {
                Console.WriteLine("C aprobado");
            }
            else if (efin >= 70)
            {
                Console.WriteLine("D aprobado");
            }
            else if (efin >= 60)
            {
                Console.WriteLine("FE Reprobado");
            }
            else if (efin >= 50)
            {
                Console.WriteLine("FI Reprobado");
            }
            else if(efin >= 0)
            {
                Console.WriteLine("F Reprovado");
            }


            Console.Write("ARIEL SOSA MATOS, 15-MISN-1-018");
            Console.ReadKey();

        }
    }
}
    

