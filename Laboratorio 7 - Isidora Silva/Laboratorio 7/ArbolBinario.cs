using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7
{
    public class ArbolBinario
    {
        class Nodo
        {
            public int informacion;
            public Nodo izquerda, derecha;
        }
        Nodo raiz;
        public void Insertar(int informacion)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.informacion = informacion;
            nuevo.izquerda = null;
            nuevo.derecha = null;
            if (raiz == null)
                raiz = nuevo;
            else
            {
                Nodo anterior = null, reco;
                reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (informacion < reco.informacion)
                        reco = reco.izquerda;
                    else
                        reco = reco.derecha;
                }
                if (informacion < anterior.informacion)
                    anterior.izquerda = nuevo;
                else
                    anterior.derecha = nuevo;
            }
        }
    }
}
