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
    public partial class SeleccionarCoordFinal : Form
    {

        public SeleccionarCoordFinal()
        {
            InitializeComponent();
            Inicializar();
        }

        Point P;

        void Inicializar()
        {
            for (int i = 1; i < 16; i++)
            {
                comboI.Items.Add(i);
                comboJ.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboI.SelectedItem == null || comboJ.SelectedItem == null)
            {
                MessageBox.Show("Error");
            }
            else
            {
                P = new Point(Int32.Parse(comboI.SelectedItem.ToString()), Int32.Parse(comboJ.SelectedItem.ToString()));
                this.Close();
               // MessageBox.Show(P.X.ToString() + P.Y.ToString());
            }
        }

        public Point getFinal()
        {
            return this.P;

        }
    }
}
