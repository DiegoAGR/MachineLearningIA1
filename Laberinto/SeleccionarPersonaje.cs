using System;
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
    public partial class SeleccionarPersonaje : Form
    {
        public string opcion = "";
        public SeleccionarPersonaje()
        {
           
            InitializeComponent();
            ponerImagenes();
           


            
            void ponerImagenes()
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;


                this.pictureBox1.Image = Image.FromFile("Sonic.png");
                this.pictureBox2.Image = Image.FromFile("Link.png");
                this.pictureBox3.Image = Image.FromFile("cyber.png");
            }
           


        }
            void definirOpcion()
            {
                if (radioButton1.Checked)
                {
                    opcion = "Sonic";
                }
                else if (radioButton2.Checked)
                {
                    opcion = "Link";
                }
                else if (radioButton3.Checked)
                {
                    opcion = "Cyber";
                }
               
            }
        private void button1_Click(object sender, EventArgs e)
        {
            definirOpcion();
            if (opcion!="")
            {
                Form1.Personaje = opcion;
                
                this.Close();
                
            }
            else
            {
                MessageBox.Show("No seleccionaste ningun personaje");
            }
        }

        public string getOpcion()
        {
            return this.opcion;
        }
    }
}
