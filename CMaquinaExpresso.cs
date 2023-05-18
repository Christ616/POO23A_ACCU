using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_ACCU
{
    //-------------------------------------------------------------------------
    // Clase que representa una maquina de expresso.
    // ACCU. 21/02/2023.
    //-------------------------------------------------------------------------
    public class CMaquinaExpresso
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------
        private bool Encendido; //true, false.
        private int CantidadAgua; //1 lt, 2 lt, 3 lt, 4 lt, 5 lt.
        private int CapacidadCafe; //100 g, 200 g, 300 g, 400 g, 500 g.
        private int Temperatura; //Ejemplo: 50°
        private int Presion; //Ejemplo: 1 bar.
        private int Tipo; // 1 = Automática, 2 = Superautomática.
        private int Marca; // 1 = Pavoni, 2 = Cimbali, 3 = San Remo, 4 = Cime.
        private int LugarFabricacion; // 1 = Italia, 2 = Otro lugar.
        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public CMaquinaExpresso(int Tipo, int Marca, int LugarFabricacion)
        {
            //Recibe atributos.
            this.Tipo = Tipo;
            this.Marca = Marca;
            this.LugarFabricacion = LugarFabricacion;

            //Inicializa atributos.
            CantidadAgua = 5;
            CapacidadCafe = 1000;
            Temperatura = 30;
            Presion = 0;
        }
        public void Encender()
        {
            
        }

        public void Apagar()
        {

        }

        public void HacerExpresso()
        {

        }

        public void RellenarAgua(int CantidadAgua)
        {

        }

        public void AgregarCafe(int CantidadCafe)
        {

        }

        private void AjustarTemperatura(int Temperatura)
        {

        }

        private void AjustarPresion(int Presion)
        {

        }
    }
} // Fin de la Clase.