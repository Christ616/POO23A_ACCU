namespace POO23A_ACCU
{
    //-------------------------------------------------------------------------
    // Clase que representa una calculadora básica.
    // ACCU. 07/02/2023.
    //-------------------------------------------------------------------------
    public class CCalculadoraBasica
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------
        private double Operando1;
        private double Operando2;
        private double Resultado;
        private const double ERROR = -1;
        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public CCalculadoraBasica(double Operando1, double Operando2)
        {
            this.Operando1 = Operando1;
            this.Operando2 = Operando2;
        }
        //-------------------------------------------------------------------------
        // Suma los operandos.
        //-------------------------------------------------------------------------
        public double Suma()
        {
            Resultado = Operando1 + Operando2;
            return Resultado;
        }
        //-------------------------------------------------------------------------
        // Resta los operandos.
        //-------------------------------------------------------------------------
        public double Resta()
        {
            Resultado = Operando1 - Operando2;
            return Resultado;
        }
        //-------------------------------------------------------------------------
        // Multiplica los operandos.
        //-------------------------------------------------------------------------
        public double Multiplica()
        {
            Resultado = Operando1 * Operando2;
            return Resultado;
        }
        //-------------------------------------------------------------------------
        // Divide los operandos.
        //-------------------------------------------------------------------------
        public double Divide()
        {
            if (Operando2 == 0)
            {
                Resultado = ERROR;
            }
            else
            {
                Resultado = Operando1 / Operando2;
            }
            return Resultado;
        }
        //-------------------------------------------------------------------------
        // Obtiene el resultado de la calculadora en este momento.
        //-------------------------------------------------------------------------
        public double GetResultado()
        {
            return Resultado;
        }
    }
}