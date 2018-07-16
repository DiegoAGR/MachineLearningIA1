using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laberinto
{
    class Paso
    {
        private Point Lugar;
        private double Peso;
        private string Tipo;

        public Paso(Point d, double e,string t)
        {
            this.Lugar = d;
            this.Peso = e;
            this.Tipo = t;
        }

        public string getTipo()
        {
            return this.Tipo;
        }

        public Point getLugar()
        {
            return this.Lugar;
        }

        public double getPeso()
        {
            return this.Peso;
        }
    }
}
