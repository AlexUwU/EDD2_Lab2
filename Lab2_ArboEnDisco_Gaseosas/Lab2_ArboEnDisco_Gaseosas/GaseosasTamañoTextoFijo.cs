using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2_ArboEnDisco_Gaseosas
{
    public interface IGaseosasTamañoTextoFijo<T> where T : TextoTamañoFIJO
    {
        T Create(string textoTamañoFijo);

        T CreateNulo();
    }
}
