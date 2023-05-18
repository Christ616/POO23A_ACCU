using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace POO23A_ACCU
{
    //-------------------------------------------------------------------------
    // Diálogo de la práctica 2.
    // ACCU. 02/05/2023.
    //-------------------------------------------------------------------------
    public partial class DlgPractica2 : Form
    {
        //-------------------------------------------------------------------------
        // Atributos.
        //-------------------------------------------------------------------------
        private int Velocidad;
        //private bool Velocidad1;
        private Thread ProcesoCoalicion;
        private bool Colision;
        private List<CZombie>Zombies = new List<CZombie>();
        //-------------------------------------------------------------------------
        // Constructor.
        //-------------------------------------------------------------------------
        public DlgPractica2()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            //Velocidad1 = true;
            Colision = false;

            // Asignar el evento FormClosing al formulario
            this.FormClosing += DlgPractica2_FormClosing;
        }

        //-------------------------------------------------------------------------
        // Encender el double buffering (Jorge Macias)                       
        //-------------------------------------------------------------------------
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_COMPOSITED = 0x02000000;
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_COMPOSITED;  // WS_EX_COMPOSITED
                return cp;
            }
        }
        //-------------------------------------------------------------------------
        // Crea un Zombie Pasivo.
        //-------------------------------------------------------------------------
        private void BtnZombie_Click(object sender, EventArgs e)
        {
            CZombiePasivo Zombie;

            Zombie = new CZombiePasivo(this.PbxFondo);
            Zombie.Nacer();
            Velocidad = 80;
            //Velocidad = Velocidad1 ? 2 :20;
            if (!Zombie.IsDisposed)
            {
                Zombie.Desplazar(Velocidad);
                PbxFondo.Refresh();
                Zombies.Add(Zombie); // Agregar el zombie a la lista
            }
            //Velocidad1 = !Velocidad1;
        }
        //-------------------------------------------------------------------------
        // Crea un Zombie romero.
        //-------------------------------------------------------------------------
        private void BtnZombieRomero_Click(object sender, EventArgs e)
        {
            CZombieRomero Zombie;

            Zombie = new CZombieRomero(this.PbxFondo);
            Zombie.Nacer();
            Velocidad = 40;
            if (!Zombie.IsDisposed)
            {
                Zombie.Desplazar(Velocidad);
                PbxFondo.Refresh();
                Zombies.Add(Zombie); // Agregar el zombie a la lista
            }
        }
        //-------------------------------------------------------------------------
        // Crea un Perro Zombie.
        //-------------------------------------------------------------------------
        private void BtnZombieDog_Click(object sender, EventArgs e)
        {
            CZombieDog Zombie;

            Zombie = new CZombieDog(this.PbxFondo);
            Zombie.Nacer();
            Velocidad = 1;
            if (!Zombie.IsDisposed)
            {
                Zombie.Desplazar(Velocidad);
                PbxFondo.Refresh();
                Zombies.Add(Zombie); // Agregar el zombie a la lista
            }
        }
        //-------------------------------------------------------------------------
        // Inicia el proceso de verificacion de coalición e inicia apocalipsis.
        //-------------------------------------------------------------------------
        private void BtnCoalicion_Click(object sender, EventArgs e)
        {
            ProcesoCoalicion = new Thread (() =>
            {
                int[] Localizacion;
                int[] Localizacion2;

                Colision = true;

                Localizacion = new int[4];
                Localizacion2 = new int[4];

                while (Colision)
                {
                    // Etapa1: Obtiene coordenadas y procesa color
                    Control[] ControlsCopia = this.PbxFondo.Controls.Cast<Control>().ToArray();

                    foreach (Control Control in ControlsCopia)
                    {
                        if (Control is CZombiePasivo || Control is CZombieRomero || Control is CZombieDog)
                        {
                            CZombie Zombie = (CZombie)Control;
                            Localizacion = Zombie.GetAreaLacolizacion();
                            if (!Zombie.IsDisposed)
                            {
                                Thread.Sleep(500);
                                //Zombie.BackColor = Color.GreenYellow;
                                Zombie.Text = Localizacion[0].ToString() + ", " +
                                Localizacion[1].ToString();
                                Thread.Sleep(500);
                                //Zombie.BackColor = Color.Yellow;
                                Zombie.Text = Localizacion[0].ToString() + ", " +
                                Localizacion[1].ToString();
                            }
                            Zombies.Add(Zombie); // Agregar CZombie a la lista
                        }
                    }

                    // Etapa2: Compara coordenadas y colisión (Matar Zombies)
                    for (int i = 0; i < Zombies.Count - 1; i++)
                    {
                        CZombie Zombie1 = Zombies[i];

                        for (int j = i + 1; j < Zombies.Count; j++)
                        {
                            CZombie Zombie2 = Zombies[j];

                            Localizacion = Zombie1.GetAreaLacolizacion();
                            Localizacion2 = Zombie2.GetAreaLacolizacion();
                            int Z1X1, Z1Y1, Z1X2, Z1Y2;
                            int Z2X1, Z2Y1, Z2X2, Z2Y2;

                            Z1X1 = Localizacion[0];
                            Z1Y1 = Localizacion[1];
                            Z1X2 = Localizacion[2];
                            Z1Y2 = Localizacion[3];

                            Z2X1 = Localizacion2[0];
                            Z2Y1 = Localizacion2[1];
                            Z2X2 = Localizacion2[2];
                            Z2Y2 = Localizacion2[3];

                            if ((Z2X1 >= Z1X1 - 60 && Z2X1 <= Z1X2) &&
                            (Z2Y1 >= Z1Y1 - 85 && Z2Y1 <= Z1Y2))
                            {
                                if ((Zombie1 is CZombiePasivo && Zombie2 is CZombieRomero) ||
                            (Zombie2 is CZombiePasivo && Zombie1 is CZombieRomero))
                                {
                                    CZombiePasivo ZombiePasivo = Zombie1 is CZombiePasivo ?
                                        (CZombiePasivo)Zombie1 : (CZombiePasivo)Zombie2;
                                    CZombieRomero ZombieRomero = Zombie1 is CZombieRomero ?
                                        (CZombieRomero)Zombie1 : (CZombieRomero)Zombie2;

                                    // Mostrar el mensaje de colisión en el hilo principal
                                    Invoke((Action)(() =>
                                    {
                                        ZombiePasivo.Morir(); // Destruir CZombiePasivo
                                        PbxFondo.Controls.Remove(ZombiePasivo);
                                        PbxFondo.Refresh(); // Actualizar el PictureBox
                                    }));
                                }

                                if ((Zombie1 is CZombiePasivo && Zombie2 is CZombieDog) ||
                                    (Zombie2 is CZombiePasivo && Zombie1 is CZombieDog))
                                {
                                    CZombiePasivo ZombiePasivo = Zombie1 is CZombiePasivo ?
                                        (CZombiePasivo)Zombie1 : (CZombiePasivo)Zombie2;
                                    CZombieDog ZombieDog = Zombie1 is CZombieDog ?
                                        (CZombieDog)Zombie1 : (CZombieDog)Zombie2;

                                    // Mostrar el mensaje de colisión en el hilo principal
                                    Invoke((Action)(() =>
                                    {
                                        ZombiePasivo.Morir(); // Destruir CZombiePasivo
                                        PbxFondo.Controls.Remove(ZombiePasivo);
                                        PbxFondo.Refresh(); // Actualizar el PictureBox
                                    }));
                                }

                                if ((Zombie1 is CZombieRomero && Zombie2 is CZombieDog) ||
                                    (Zombie2 is CZombieRomero && Zombie1 is CZombieDog))
                                {
                                    CZombieRomero ZombieRomero = Zombie1 is CZombieRomero ?
                                        (CZombieRomero)Zombie1 : (CZombieRomero)Zombie2;
                                    CZombieDog ZombieDog = Zombie1 is CZombieDog ?
                                        (CZombieDog)Zombie1 : (CZombieDog)Zombie2;

                                    // Mostrar el mensaje de colisión en el hilo principal
                                    Invoke((Action)(() =>
                                    {
                                        ZombieRomero.Morir(); // Destruir CZombiePasivo
                                        PbxFondo.Controls.Remove(ZombieRomero);
                                        PbxFondo.Refresh(); // Actualizar el PictureBox
                                    }));
                                }
                            }
                        }
                    }

                    // Etapa3: Verificar si quedan CZombies
                    bool MuertosVivos;

                    MuertosVivos = false;

                    foreach (Control Control in ControlsCopia)
                    {
                        if (Control is CZombiePasivo || Control is CZombieRomero || Control is CZombieDog)
                        {
                            MuertosVivos = true;
                            break;
                        }
                    }

                    if (!MuertosVivos)
                    {
                        // Todos los CZombies han sido destruidos, terminar el apocalipsis
                        Colision = false;
                    }
                }
            });

            ProcesoCoalicion.Start();
        }
        //-------------------------------------------------------------------------
        // Maneja el evento de cierre del formulario
        //-------------------------------------------------------------------------
        private void DlgPractica2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Colision = false;

            if (ProcesoCoalicion != null && ProcesoCoalicion.IsAlive)
            {
                ProcesoCoalicion.Join();
                ProcesoCoalicion = null;
            }
        }
    }
}