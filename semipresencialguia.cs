using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class GuiaSemi : Guia
    {
        public override void Mostrar()
        {
            Console.WriteLine("Mostar la guia de forma hibrida");
        }
    }

    public class ExamenSemiPresencial : Examen
    {
        public override void Aplicar()
        {
            Console.WriteLine("Se aplica examen en casa o en linea");
        }
    }
}