using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MaterialHibridoFactory : MaterialFactory
    {
        public override Guia CrearGuia()
        {
            return new GuiaSemi();
        }
        public override Examen CrearExamen()
        {
            return new ExamenSemiPresencial();
        }
    }
}