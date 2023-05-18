using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace POO23A_ACCU
{
    //-------------------------------------------------------------------------
    // Diálogo de la práctica 1.
    // ACCU. 9/02/2023.
    //-------------------------------------------------------------------------
    public partial class DlgPractica1 : Form
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------
        Graphics Panel;
        Pen Pluma;
        float x = 10;
        float y = 200;
        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public DlgPractica1()
        {
            InitializeComponent();
            Panel = PnlDibujo.CreateGraphics();
        }
        //-------------------------------------------------------------------------
        // Botón que cierra el dialogo.
        //-------------------------------------------------------------------------
        private void P1BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-------------------------------------------------------------------------
        // Botón que crea 3 calculadoras en variables independientes.
        //-------------------------------------------------------------------------
        private void BtnCalculadora_Click(object sender, EventArgs e)
        {
                   
            CCalculadoraBasica MiCalculadora1;
            CCalculadoraBasica MiCalculadora2;
            CCalculadoraBasica MiCalculadora3;
            List<CCalculadoraBasica> MiListaCalculadoras;
            double Resultado;
            double Sumatoria;

            //Se crean las calculadoras.

            MiCalculadora1 = new CCalculadoraBasica(2, 3);
            MiCalculadora2 = new CCalculadoraBasica(4, 5);
            MiCalculadora3 = new CCalculadoraBasica(6, 7);

            //Se agregan a la lista.

            MiListaCalculadoras = new List<CCalculadoraBasica>();
            MiListaCalculadoras.Add(MiCalculadora1);
            MiListaCalculadoras.Add(MiCalculadora2);
            MiListaCalculadoras.Add(MiCalculadora3);

            //Se realizan las operaciones.

            Resultado = MiCalculadora1.Suma();
            MessageBox.Show("El resultado de la suma en cal 1 es " + Resultado.ToString());

            Resultado = MiCalculadora1.Resta();
            MessageBox.Show("El resultado de la resta es " + Resultado.ToString());

            Resultado = MiCalculadora1.Multiplica();
            MessageBox.Show("El resultado de la multiplicación es " + Resultado.ToString());

            Resultado = MiCalculadora1.Divide();
            MessageBox.Show("El resultado de la división es " + Resultado.ToString());

            Resultado = MiCalculadora2.Suma();
            MessageBox.Show("El resultado de la suma en cal 2 es " + Resultado.ToString());

            Resultado = MiCalculadora3.Suma();
            MessageBox.Show("El resultado de la suma en cal 3 es " + Resultado.ToString());

            //Recorre la lista de calculadoras para obtener su sumatoria.

            Sumatoria = 0;

            foreach (CCalculadoraBasica CalculadoraAux in MiListaCalculadoras)
            {
                Sumatoria += CalculadoraAux.GetResultado();

            }
            
            MessageBox.Show("El resultado obtenido dentro de la lista es: " + Sumatoria);
        }
        //-------------------------------------------------------------------------
        // Botón que crea 10000000 dentro de un iterador.
        //-------------------------------------------------------------------------
        private void Btn100Calc_Click(object sender, EventArgs e)
        {
            //Crea la lista.

            List<CCalculadoraBasica> calculadoras = new List<CCalculadoraBasica>();

            double Operando1;
            double Operando2;

            Operando1 = 1;
            Operando2 = 2;

            //Itera la creacion de un objeto calculadora.
            for (int i = 0; i < 1000000; i++)
            {
                CCalculadoraBasica calculadora = new CCalculadoraBasica(Operando1, Operando2);
                calculadoras.Add(calculadora);
                Operando1 += 2;
                Operando2 += 2;
            }

            double sumatoria = 0;

            //Recorre la lista de calculadoras para obtener su sumatoria.

            foreach (CCalculadoraBasica calculadora in calculadoras)
            {
                sumatoria += calculadora.Multiplica();
            }

            MessageBox.Show("La sumatoria de la multiplicación de los operandos de las 1000000 calculadoras es: " + sumatoria);
        }
        //-------------------------------------------------------------------------
        // Botón que crea los objetos de figuras geométricas y calcula sus áreas.
        //-------------------------------------------------------------------------
        private void BtnFigura_Click(object sender, EventArgs e)
        {
            PointF punto1;
            PointF punto2;
            PointF punto3;
            PointF punto4;
            PointF punto5;
            PointF punto6;
            PointF punto7;
            Array puntos;

            //int HashCode;
            string Nombre;
            double Resultado;
            Pluma = new Pen(Color.White, 3);
            //Panel.DrawLines(Pluma);
            //double ResultadoMV;
            CTriangulo MiTriangulo;
            CCuadrado MiCuadrado;
            CRectangulo MiRectangulo;
            CPentagono MiPentagono;
            CHexagono MiHexagono;
            CHeptagono MiHeptagono;
            COctagono MiOctagono;
            

            //MiTriangulo = new CTriangulo();
            //HashCode = MiTriangulo.GetHashCode();

            //MessageBox.Show("El código Hash del triangulo es: " + HashCode.ToString());

            //MiCuadrado = new CCuadrado();
            //HashCode = MiCuadrado.GetHashCode();

            //MessageBox.Show("El código Hash del cuadrado es: " + HashCode.ToString());

            //MiRectangulo = new CRectangulo();
            //HashCode = MiRectangulo.GetHashCode();

            //MessageBox.Show("El código Hash del rectangulo es: " + HashCode.ToString());

            //MiPentagono = new CPentagono();
            //HashCode = MiPentagono.GetHashCode();

            //MessageBox.Show("El código Hash del pentagono es: " + HashCode.ToString());

            //MiHexagono = new CHexagono();
            //HashCode = MiHexagono.GetHashCode();

            //MessageBox.Show("El código Hash del hexagono es: " + HashCode.ToString());
            
            MiTriangulo = new CTrianguloEqu(Color.White, 400, 346);
            MiTriangulo.CalculaArea();
            Resultado = MiTriangulo.GetArea();
            Nombre = MiTriangulo.GetNombre();
            punto1 = new PointF(x, y);
            punto2 = new PointF(x + 200,y);
            punto3 = new PointF(x + 100, y - 173);
            PointF[] equilatero =
                {
                punto1, punto2, punto3
                };
            Panel.DrawPolygon(Pluma, equilatero);
            MessageBox.Show("Hola, soy un " + Nombre + " y mi área es de " + Resultado + " cm²");
            Panel.Clear(Color.Black);
            

            MiTriangulo = new CTrianguloIso(Color.Yellow, 50, 75);
            MiTriangulo.CalculaArea();
            Resultado = MiTriangulo.GetArea();
            Nombre = MiTriangulo.GetNombre();
            punto1 = new PointF(x, y);
            punto2 = new PointF(x + 140, y);
            punto3 = new PointF(x + 70, y - 195);
            PointF[] Isosceles =
                {
                punto1, punto2, punto3
                };
            Panel.DrawPolygon(Pluma, Isosceles);
            MessageBox.Show("Hola, soy un " + Nombre + " y mi área es de " + Resultado + " cm²");
            Panel.Clear(Color.Black);

            MiTriangulo = new CTrianguloEsc(Color.Green, 30, 50);
            MiTriangulo.CalculaArea();
            Resultado = MiTriangulo.GetArea();
            Nombre = MiTriangulo.GetNombre();
            punto1 = new PointF(x, y);
            punto2 = new PointF(x + 180, y);
            punto3 = new PointF(x + 50, y - 150);
            PointF[] Escaleno =
                {
                punto1, punto2, punto3
                };
            Panel.DrawPolygon(Pluma, Escaleno);
            MessageBox.Show("Hola, soy un " + Nombre + " y mi área es de " + Resultado + " cm²");
            Panel.Clear(Color.Black);

            MiCuadrado = new CCuadrado(Color.Red, 10);
            MiCuadrado.CalculaArea();
            Resultado = MiCuadrado.GetArea();
            Nombre = MiCuadrado.GetNombre();
            punto1 = new PointF(x, y);
            punto2 = new PointF(x + 180, y);
            punto3 = new PointF(x + 180, y - 180);
            punto4 = new PointF(x, y -180);
            PointF[] Cuadrado =
                {
                punto1, punto2, punto3, punto4
                };
            Panel.DrawPolygon(Pluma, Cuadrado);
            MessageBox.Show("Hola, soy un " + Nombre + " y mi área es de " + Resultado + " cm²");
            Panel.Clear(Color.Black);

            MiRectangulo = new CRectangulo(Color.Blue, 10, 20);
            MiRectangulo.CalculaArea();
            Resultado = MiRectangulo.GetArea();
            Nombre = MiRectangulo.GetNombre();
            punto1 = new PointF(x, y);
            punto2 = new PointF(x + 180, y);
            punto3 = new PointF(x + 180, y - 100);
            punto4 = new PointF(x, y - 100);
            PointF[] Rectangulo =
                {
                punto1, punto2, punto3, punto4
                };
            Panel.DrawPolygon(Pluma, Rectangulo);
            MessageBox.Show("Hola, soy un " + Nombre + " y mi área es de " + Resultado + " cm²");
            Panel.Clear(Color.Black);

            MiPentagono = new CPentagono(Color.Black, 6);
            MiPentagono.CalculaArea();
            Resultado = MiPentagono.GetArea();
            Nombre = MiPentagono.GetNombre();
            //puntos = PuntosPoligono();
            //Panel.DrawPolygon(Pluma, puntos);
            MessageBox.Show("Hola, soy un " + Nombre + " y mi área es de " + Resultado + " cm²");
            Panel.Clear(Color.Black);

            MiHexagono = new CHexagono(Color.Brown, 45);
            MiHexagono.CalculaArea();
            Resultado = MiHexagono.GetArea();
            Nombre = MiHexagono.GetNombre();
            MessageBox.Show("Hola, soy un " + Nombre + " y mi área es de " + Resultado + " cm²");
            Panel.Clear(Color.Black);

            MiHeptagono = new CHeptagono(Color.Coral, 75);
            MiHeptagono.CalculaArea();
            Resultado = MiHeptagono.GetArea();
            Nombre = MiHeptagono.GetNombre();
            MessageBox.Show("Hola, soy un " + Nombre + " y mi área es de " + Resultado + " cm²");
            Panel.Clear(Color.Black);

            MiOctagono = new COctagono(Color.Aqua, 151);
            MiOctagono.CalculaArea();
            Resultado = MiOctagono.GetArea();
            Nombre = MiOctagono.GetNombre();
            MessageBox.Show("Hola, soy un " + Nombre + " y mi área es de " + Resultado + " cm²");
            Panel.Clear(Color.Black);
        }
    }
}