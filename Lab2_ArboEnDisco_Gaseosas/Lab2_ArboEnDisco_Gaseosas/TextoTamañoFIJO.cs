﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2_ArboEnDisco_Gaseosas
{
    public interface TextoTamañoFIJO
    {
        int FixedSizeText { get; }

        string ToFixedToSizeString();
    }
}
