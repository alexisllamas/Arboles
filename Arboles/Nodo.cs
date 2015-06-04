using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Nodo
    {
        public int dato { get; set; }

        public Nodo hIzq { get; set; }

        public Nodo hDer { get; set; }

        public Nodo(int dato)
        {
            this.dato = dato;
        }

        public override string ToString()
        {
            return dato.ToString();
        }
    }
}
