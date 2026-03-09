using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaterialFactory fabrica;
            fabrica = new MaterialPresencialFactory();

            Guia guia = fabrica.CrearGuia();
            Examen examen = fabrica.CrearExamen();

            guia.Mostrar();
            examen.Aplicar();

            Console.WriteLine("");

            fabrica = new MaterialVirtualFactory();

            guia = fabrica.CrearGuia();
            examen = fabrica.CrearExamen();

            guia.Mostrar();
            examen.Aplicar();
            Console.WriteLine("");


            fabrica = new MaterialHibridoFactory();
            guia = fabrica.CrearGuia();
            examen = fabrica.CrearExamen();

            guia.Mostrar();
            examen.Aplicar();

            Console.ReadKey();
        }
    }
}