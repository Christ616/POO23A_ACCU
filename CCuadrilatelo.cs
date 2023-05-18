using System.Drawing;

namespace POO23A_ACCU
{
    //-------------------------------------------------------------------------
    // Clase que representa un cuadrilátero.
    // ACCU. 14/03/2023.
    //-------------------------------------------------------------------------
    public class CCuadrilatelo : CPoligono
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------
        private double Lado1;
        private double Lado2;
        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public CCuadrilatelo(Color Color, double Lado1, double Lado2, string Nombre) 
            : base (Color, Nombre)
        {
            this.Lado1 = Lado1;
            this.Lado2 = Lado2;
            NumLados = 4;
        }
        //-------------------------------------------------------------------------
        // Calcula el área de un cuadrilátero.
        //-------------------------------------------------------------------------
        public double CalculaAreaOriginal()
        {
            Area = Lado1 * Lado2;
            AreaCalculada = true;

            return Area;
        }
        //-------------------------------------------------------------------------
        // Obtine el valor de los lados del cuadrilátero.
        //-------------------------------------------------------------------------
        public void SetLados(double Lado1, double Lado2)
        {
            this.Lado1 = Lado1;
            this.Lado2 = Lado2;
        }
        //-------------------------------------------------------------------------
        // Obtiene el Área del cuadrilátero.
        //-------------------------------------------------------------------------
        public override void CalculaArea()
        {
            base.CalculaArea();
            Area = Lado1 * Lado2;
        }
    }
}
