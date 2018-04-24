using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();
            arbol.Insertar(100);
            arbol.Insertar(50);
            arbol.Insertar(25);
            arbol.Insertar(867);
            arbol.Insertar(86);
        }
    }
}
