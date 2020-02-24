using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2_ArboEnDisco_Gaseosas.Models
{
    public abstract class ArbolBusqueda<TLlave, T> where TLlave : IComparable
    {
        public int Tamaño { get; set; }
        public abstract void Agregar(TLlave llave, T dato, string llaveAux);

        public abstract T Obtener(TLlave llave);
        public abstract bool Contiene(TLlave llave);


    }
}
