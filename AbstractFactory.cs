using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class MaterialFactory
    {
        public abstract Guia CrearGuia();

        public abstract Examen CrearExamen();
    }

    public abstract class Guia
    {
        public abstract void Mostrar();
    }
    
    public abstract class Examen
    {
        public abstract void Aplicar();
    }
    }