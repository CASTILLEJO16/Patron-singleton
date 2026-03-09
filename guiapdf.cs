using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class GuiaPDF : Guia 
    {
        public override void Mostrar()
        {
            Console.WriteLine("Monstrar la guia Pdf");
        }
    }

    public class ExamenOnline : Examen
    {
       public override void Aplicar()
        {
            Console.WriteLine("Se aplica examen en linea");
        }
    }

}