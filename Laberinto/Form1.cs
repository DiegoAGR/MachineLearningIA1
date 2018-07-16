﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laberinto
{
    public partial class Form1 : Form
    {
        public static string Personaje;

        public Form1()
        {
           InitializeComponent();
           Rellenar();        
        }

        Point Final, Inicio, Actual;
        int contadorVisita;
        int i;
        int numEntrenamiento;
        int entrenamientos;
        Image iniImg;
        Image temp;
        Image temp2;
        Point temp3;
        List<Paso> Recorrido = new List<Paso>();
        PictureBox[,] PM = new PictureBox[15, 15];
        Terreno[,] TS = new Terreno[15, 15];
        Random rnd = new Random();
        Agente SujetoPrueba;


        string[] tokens;
        bool SelIni;
        bool entrenando;


        public static readonly string[] tipos = { "Montana","Agua","Barranco","Plano","Muro"};

        public static readonly double[] eM = { 2.5, 0.3, 1.5, 1 };
        public static readonly double[] eP = { 0.3, 2.5, 1, 1.5 };
        public static readonly double[] eL = { 1.5, 1, 2.5, 0.3 };

        void GenerarObstaculos() //Revisar cuanta memoria usa
        {
            int ran;
            double[] val;
            string tipo;
            Terreno T; 
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    ran = rnd.Next(0,100);
                    val = new double[3];
                    
                    if (ran >= 20) //Poner opcion grafica para cambiar esto
                    {
                       
                       int elegido = rnd.Next(tipos.Length);
                       tipo = tipos[elegido];

                        switch (elegido)
                        {
                            case 0:
                                val[0] = eM[0];
                                val[1] = eP[0];
                                val[2] = eL[0];

                                break;

                            case 1:
                                val[0] = eM[1];
                                val[1] = eP[1];
                                val[2] = eL[1];

                                break;

                            case 2:
                                val[0] = eM[2];
                                val[1] = eP[2];
                                val[2] = eL[2];

                                break;

                            case 3:
                                val[0] = eM[3];
                                val[1] = eP[3];
                                val[2] = eL[3];

                                break;


                            default:
                                val[0] = 0.0;
                                val[1] = 0.0;
                                val[2] = 0.0;

                                break;
                        }
                        
                    }

                    else
                    {
                    tipo = "Plano";
                        val[0] = eM[3];
                        val[1] = eP[3];
                        val[2] = eL[3];
                    }
                    
                    T = new Terreno(val, tipo);
                    if (T.getTipo() == "Muro")
                    { T.setObstaculo(true); }

                    TS[i, j] = T;

               
                }
            }
         
        }

        void Actualizar()
        {
            GenerarObstaculos();
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {

                    string imagen;
                 
                    if (TS[i, j].getObstaculo())
                    {
                        imagen = "Montana.png";
                    }
                    else
                    {
                        imagen = "plano.png";
                    }
                    
                    TS[i, j].setImagen(imagen);

                    PM[i,j].Image = Image.FromFile(TS[i, j].getImagen());

                }
            }
        }

        private void Rellenar()
        {
            GenerarObstaculos();
            Final = new Point();
            Inicio = new Point();
            SelIni = true;
            numEntrenamiento = 0;
            entrenamientos = 100;
            entrenando = false;
            
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {

                    string imagen = null;
                    string tipo = TS[i, j].getTipo();

                    switch(tipo)
                    {
                        case "Montana":
                            imagen = "Montana.png";

                            break;

                        case "Agua":
                            imagen = "Agua.png";
                            break;

                        case "Barranco":
                            imagen = "Barranco.png";
                            break;

                        case "Plano":
                            imagen = "Plano.png";
                                break;

                        case "Muro":
                            imagen = "Muro.png";
                            break;

                    }

                 
                    TS[i, j].setImagen(imagen);

                    PictureBox P = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Image = Image.FromFile(TS[i, j].getImagen()),
                        Width = 40,
                        Height = 40,
                        Top = 40 * j,
                        Left = 40 * i
                    };

                    P.MouseClick += P_MouseClick;
                    int tempi, tempj;
                    tempi = i + 1;
                    tempj = j + 1;
                    P.Tag = tempi.ToString()+","+tempj.ToString();
                    
                    void P_MouseClick(object sender, MouseEventArgs e)
                    {
                            tokens = P.Tag.ToString().Split(',');
                            int coordi = Convert.ToInt32(tokens[0]) - 1;
                            int coordj = Convert.ToInt32(tokens[1]) - 1;


                        if (e.Button == MouseButtons.Right)
                        {
                            
                            PM[temp3.X, temp3.Y].Image = temp2;
                            temp2 = P.Image;

                            P.Image = Image.FromFile(Personaje);
                            temp3.X = coordi;
                            temp3.Y = coordj;
                           
                        }

                            if (e.Button == MouseButtons.Left)
                            {
                           

                            if (!TS[coordi, coordj].getObstaculo())
                            {
                                if (SelIni)
                                {
                                    try
                                    {
                                        temp = P.Image;
                                        temp2 = temp;
                                        iniImg = P.Image;
                                        P.Image = Image.FromFile(Personaje);
                                        textBox1.Text = P.Tag.ToString();
                                        Inicio.X = coordi;
                                        Inicio.Y = coordj;
                                        
                                        temp3 = Inicio;
                                        SelIni = false;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("No has seleccionado ningun personaje, seleccionalo");
                                    }
                                    
                                }
                                else
                                {
                                    P.Image = Image.FromFile("Casa.png");
                                    textBox2.Text = P.Tag.ToString();
                                    Final.X = coordi;
                                    Final.Y = coordj;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se puede iniciar en esta casilla porque es un obstaculo");
                            }
                        }

                    }

                    PM[i, j] = P;
                    panel1.Controls.Add(PM[i, j]);

                }
            }
            panel1.Size = new Size(40 * 15, 40 * 15);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, System.EventArgs e)
        {

            Actualizar();
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            SeleccionarPersonaje m = new SeleccionarPersonaje();
            var dialogResult = m.ShowDialog();
            textPersonaje.Text = m.getOpcion();
            SujetoPrueba = new Agente(m.getOpcion(),entrenamientos); //Reemplazar el 10 con un valor de algun textbox
            Personaje = m.getOpcion() + ".png";
            m.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            entrenando = true;
            Jugar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textPersonaje.Text = SujetoPrueba.getNombre();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
                if (Actual == Final)
                {
                    timer1.Stop();
                    SujetoPrueba.actualizarEntr();
                   
                    SujetoPrueba.setRecorrido(Recorrido);
                    SujetoPrueba.CalcularEsfuerzoTotal();
                    AjustarPonderaciones();
                    
                    numEntrenamiento++;
                    textNumEntr.Text = numEntrenamiento.ToString();
                    
                    verPonderaciones();
                    Reiniciar();
                }
                else
                {
                    Esquivar(Actual);
                
                }
            
        }

        void verPonderaciones()
        {
            if (numEntrenamiento == 0 || numEntrenamiento == entrenamientos)
            {
                Console.WriteLine(SujetoPrueba.getEstado());
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        Console.WriteLine("Casilla: "+i.ToString()+","+j.ToString()+" : "+TS[i, j].getPonderacion(SujetoPrueba.getNombre()));
                    }
                }
            }
        }

        void AjustarPonderaciones()
        {
            List<Paso> Aux = SujetoPrueba.getRecorrido();
            double temp = SujetoPrueba.getAjuste();

            for (int i = 0; i < Aux.Count; i++)
            {
                    TS[Aux[i].getLugar().X, Aux[i].getLugar().Y].Ponderar(SujetoPrueba.getNombre(), temp);   
            }
        }

        void Jugar()
        {
            if(numEntrenamiento == entrenamientos-1)
            {
                entrenando = false;
            }
            if (SujetoPrueba == null)
            {
                MessageBox.Show("No has seleccionado un personaje para jugar.");
            }
            else
            {
                
                //trackBar1.Enabled = false;
                Actual = Inicio;
                
                Paso P = new Paso(Inicio,TS[Inicio.X, Inicio.Y].getPeso(SujetoPrueba.getNombre()), TS[Inicio.X,Inicio.Y].getTipo());
                Recorrido.Add(P);
                textActual.Text = "X: " + Actual.X.ToString() + "Y: " + Actual.Y.ToString();

                i = 1;

                timer1.Interval = 1;
                timer1.Start();
            }

        }


        void PrimeroElMejor(Point P)
        {
            int xv;
            int yv;
            Point Mejor;

            xv = P.X;
            yv = P.Y;

            Point[] Pos = new Point[]
            {
           
            new Point { X = xv, Y = yv-1},
            new Point { X = xv+1, Y = yv-1 },
            new Point { X = xv+1, Y = yv },
            new Point { X = xv+1, Y = yv+1 },
            new Point { X = xv, Y = yv+1 },
            new Point { X = xv-1, Y =  yv+1},
            new Point { X = xv-1, Y = yv},
            new Point { X = xv-1, Y = yv-1 }
            };

            bool[] invalidos = new bool[8];

            string n = SujetoPrueba.getNombre();
            Mejor = new Point();
            Point Aux = new Point();


            Aux = Pos[0];

            for (int i = 1; i < Pos.Length; i++)
            {
            
                if (esCoordValida(Aux) && esCoordValida(Pos[i]) && !fueVisitado(Aux) && !fueVisitado(Pos[i]))
                {
                    if (TS[Pos[i].X, Pos[i].Y].getPonderacion(n) < TS[Mejor.X, Mejor.Y].getPonderacion(n))
                    {
                        Mejor = Pos[i];
                    }
                }
                else
                {

                    Aux = Pos[i];

                }

            }


            if (!esCoordValida(Mejor) || fueVisitado(Mejor))
            {
                for (int j = 0; j < Pos.Length; j++)
                {
                    if (esCoordValida(Pos[j]))
                    {
                        if (!TS[Pos[j].X, Pos[j].Y].getObstaculo() && !Pos[j].Equals(Mejor) && !Pos[j].Equals(Recorrido[i-1]))
                        {
                            Mejor = Pos[j];
                            break;
                        }
                    }
                }
            }

            textActual.Text = "X: " + Actual.X.ToString() + "Y: " + Actual.Y.ToString();
            Actual = Mejor;

            Moverse(Actual);
        }

        void Esquivar(Point n)
        {
            contadorVisita = 0;
            int xv;
            int yv;
            Point Nuevo;
            int posnueva;

            xv = n.X;
            yv = n.Y;

            int[,] Posiciones = new int[,]
            {
                { xv, yv-1 },
                { xv+1, yv-1 },
                { xv+1, yv },
                { xv+1, yv+1 },
                { xv, yv+1 },
                { xv-1, yv+1 },
                { xv-1, yv },
                { xv-1, yv-1 }
            };

            posnueva = rnd.Next(Posiciones.GetLength(0));

            Nuevo = new Point( Posiciones[posnueva,0], Posiciones[posnueva, 1]);
            while (!esCoordValida(Nuevo) && !fueVisitado(Nuevo))
            {
                posnueva = rnd.Next(Posiciones.GetLength(0));

                Nuevo.X = Posiciones[posnueva, 0];
                Nuevo.Y = Posiciones[posnueva, 1];
                contadorVisita++;

                if(contadorVisita==8)
                {
                    posnueva = rnd.Next(Posiciones.GetLength(0));

                    Nuevo.X = Posiciones[posnueva, 0];
                    Nuevo.Y = Posiciones[posnueva, 1];

                    while (!esCoordValida(Nuevo))
                    {
                        posnueva = rnd.Next(Posiciones.GetLength(0));

                        Nuevo.X = Posiciones[posnueva, 0];
                        Nuevo.Y = Posiciones[posnueva, 1];

                    }
                    
                    //break;
                }
            }
            
            Actual = Nuevo;
            textActual.Text = "X: "+Actual.X.ToString() + "Y: "+Actual.Y.ToString();
            Posiciones = null;
            Moverse(Actual);
            
        }

        void Moverse(Point n)
        {
            int xn;
            int yn;
            xn = n.X;
            yn = n.Y;


            try {
                PM[Recorrido[i - 1].getLugar().X, Recorrido[i - 1].getLugar().Y].Image = temp;
            }
            catch (System.ArgumentOutOfRangeException e)
            {

                MessageBox.Show("Coordenadas malas: " + xn.ToString() + " " + yn.ToString() + "Indice malo: " +i.ToString());
            }

            try {
                
                temp = PM[xn, yn].Image;
            }
            catch (System.IndexOutOfRangeException e)
            {
                MessageBox.Show("Coordenadas malas: "+ xn.ToString() + " "+yn.ToString());
            }

            PM[xn, yn].Image = Image.FromFile(Personaje);
            i++;
            panel1.Update();
            Paso P = new Paso(Actual, TS[xn, yn].getPeso(SujetoPrueba.getNombre()), TS[xn, yn].getTipo());
            Recorrido.Add(P);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("bnf.png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }


        void Reiniciar()
        {
            PM[Final.X, Final.Y].Image = Image.FromFile("Casa.png");
            PM[Inicio.X, Inicio.Y].Image = Image.FromFile(Personaje);
            temp = Image.FromFile(TS[Inicio.X, Inicio.Y].getImagen());
            Recorrido.Clear();
            if(entrenando)
            {
               
                Jugar();
            }
            else
            {
                MessageBox.Show("Entrenamiento termiando");
                SujetoPrueba.MostrarDatosRecorrido();
               // Explotar();
            }
        }

        void Explotar()
        {
          
            i = 1;
       
            textActual.Text = "";
            Reiniciar();
            Paso P = new Paso(Inicio, TS[Inicio.X, Inicio.Y].getPeso(SujetoPrueba.getNombre()), TS[Inicio.X, Inicio.Y].getTipo());
            Recorrido.Add(P);
            Actual = Inicio;
            timer2.Interval = 100;
            timer2.Start();
        }

        bool fueVisitado(Point P)
        {
            if (Recorrido.Exists(x => x.getLugar() == P))
            { return true; }
            else
            { return false; }
        }

        private void botonExplotar_Click(object sender, EventArgs e)
        {
            Explotar();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Actual == Final)
            {
                timer2.Stop();
            }
            else
            {
                PrimeroElMejor(Actual);
            }

        }

        bool esCoordValida(Point P)
        {
            bool val = true;

            if (P.X < 0)
            { val = false; }
            else if (P.X > 14) //Investigar como sacar las medidas de la matriz
            { val = false; }
            else if (P.Y < 0)
            { val = false; }
            else if (P.Y > 14)
            { val = false; }
            else if(TS[P.X,P.Y].getObstaculo())
            { val = false; }
            
            return val;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}