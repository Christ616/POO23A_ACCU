using System;
using System.Drawing;

namespace POO23A_ACCU
{
    //-------------------------------------------------------------------------
    // Clase que representa una figura.
    // ACCU. 14/03/2023.
    //-------------------------------------------------------------------------
    public class CFigura
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------
        protected string Nombre;
        protected Color Color;
        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public CFigura(Color Color, string Nombre)
        {
            this.Color = Color;
            this.Nombre = Nombre;
        }
        //-------------------------------------------------------------------------
        // Dibuja una figura.
        //-------------------------------------------------------------------------
        public void Dibuja()
        {

        }
        public string GetNombre()
        {
            return Nombre;
        }
    }
}
