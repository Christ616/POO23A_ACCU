using System.Drawing;

namespace POO23A_ACCU
{
    //-------------------------------------------------------------------------
    // Clase que representa un triángulo Equilatero.
    // ACCU. 14/03/2023.
    //-------------------------------------------------------------------------
    public class CTrianguloEqu : CTriangulo
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------

        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public CTrianguloEqu(Color Color, double Base, double Altura) 
            : base(Color, Base, Altura,"Triángulo Equilátero")
        {
            NumLados = 3;
        }
    }
}