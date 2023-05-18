﻿using System.Drawing;

namespace POO23A_ACCU
{
    //-------------------------------------------------------------------------
    // Clase que representa un octágono.
    // ACCU. 14/03/2023.
    //-------------------------------------------------------------------------
    public class COctagono : CPoligonoRegular
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------

        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public COctagono(Color Color, double Lado) 
            : base(Color.Pink, "Octágono", Lado)
        {
            NumLados = 8;
        }
    }
}