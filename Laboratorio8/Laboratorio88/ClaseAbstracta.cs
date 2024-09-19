using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio88
{
    abstract class ClaseAbstracta
    {
        // Se fuerza la herencia de clase para definir estos metodos
        abstract protected string tomarValor();
        abstract public string prefixValor(string prefix);

        // Metodo comun
        public void printOut()
        {
            Console.WriteLine(tomarValor());
        }
    }
}
