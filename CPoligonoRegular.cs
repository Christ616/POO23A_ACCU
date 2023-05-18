using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace POO23A_ACCU
{
    //-------------------------------------------------------------------------
    // Clase que representa un polígono regular.
    // ACCU. 14/03/2023.
    //-------------------------------------------------------------------------
    public class CPoligonoRegular : CPoligono
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------
        protected double Lado;
        public List<PointF> puntos = new List<PointF>();
        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public CPoligonoRegular(Color Color, string Nombre,double Lado) 
            : base(Color, Nombre)
        {
            this.Lado = Lado;
        }
        //-------------------------------------------------------------------------
        // Obtiene el Área del Polígono Regular.
        //-------------------------------------------------------------------------
        public override void CalculaArea()
        {
            base.CalculaArea();
            Area = Math.Round (0.5 * Lado * NumLados * (Lado / 2 * Math.Tan(Math.PI/NumLados)),2);
        }
        public void PuntosPoligono()
        {
            // Definir el radio y el ángulo de cada vértice
            const double radio = 80.0;
            double angulo = 2 * Math.PI / NumLados;
            
            // Calcular las coordenadas de cada vértice
            for (int i = 0; i < NumLados; i++)
            {
                double x = 100 + radio * Math.Cos(i * angulo);
                double y = 100 + radio * Math.Sin(i * angulo);
                puntos.Add(new PointF((float)x, (float)y));
            }
        }
    }
}