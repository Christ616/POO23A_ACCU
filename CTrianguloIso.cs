using System.Drawing;

namespace POO23A_ACCU
{
    //-------------------------------------------------------------------------
    // Clase que representa un triángulo Isósceles.
    // ACCU. 14/03/2023.
    //-------------------------------------------------------------------------
    public class CTrianguloIso : CTriangulo
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------

        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public CTrianguloIso(Color Color, double Base, double Altura) 
            : base(Color, Base, Altura, "Triángulo Isósceles")
        {
            NumLados = 3;
        }
    }
}