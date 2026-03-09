using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MaterialPresencialFactory : MaterialFactory 
    {
        public override Guia CrearGuia()
        {
            return new GuiaImpresa();
        }
        public override Examen CrearExamen()
        {
            return new ExamenEnPapel();
        }
    }
}