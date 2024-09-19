using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio88
{
    internal class ClaseConcreta2 : ClaseAbstracta
    {
        public override string prefixValor(string prefix)
        {
            return $"{prefix}ClaseConcreta2";
        }

        protected override string tomarValor()
        {
            return "ClaseConcreta2";
        }
    }
}
