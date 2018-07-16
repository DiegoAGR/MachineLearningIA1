using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laberinto
{
    public class Terreno
    {
        private string Imagen;
        private string Nombre;
        private bool obstaculo;
        private bool bandera;
        private string tipo;
        private double[] Ponderacion = {Int32.MaxValue, Int32.MaxValue, Int32.MaxValue }; 
        private double[] esfuerzos;


        public Terreno(double[] val, string t) //mandar valores desde que se construye el terreno
        {
            
            if(tipo == "Muro")
            {
                this.obstaculo = true;
                Ponderacion[0] = 0;
                Ponderacion[1] = 0;
                Ponderacion[2] = 0;
            }
            else
            {
                esfuerzos = new double[3];
                esfuerzos = val;
                this.tipo = t;
                
            }
        }

        public string getTipo()
        {
            return this.tipo;
        }

       public double getPeso(string nombre)
        {
            double p =0;
            switch (nombre)
            {
                case "Sonic":
                    p = esfuerzos[0];
                    break;

                case "Link":
                    p = esfuerzos[1];
                    break;

                case "Cyber":
                    p = esfuerzos[2];
                    break;
                    
            }
            return p;
        }

        public double getPonderacion(string nombre)
        {
            double p = 0;
            switch (nombre)
            
            {
            
                case "Sonic":
                    p = Ponderacion[0];
                    break;

                case "Link":
                    p = Ponderacion[1];
                    break;

                case "Cyber":
                    p = Ponderacion[2];
                    break;

            }
            return p;
        }


        public void Ponderar(string nombre,double a)
            {

            switch (nombre)
            {
                case "Sonic":
                    Ponderacion[0] += a; 

                    break;

                case "Link":
                    Ponderacion[1] += a;
                    break;

                case "cyber":
                    Ponderacion[2] += a;
                    break;

            }
        }


        public void setObstaculo(bool o)
        {
            this.obstaculo = o;
        }

        public void setImagen(string i)
        {
            this.Imagen = i;
        }

        public string getImagen()
        {
            return this.Imagen;
        }

        public bool getObstaculo()
        {
            return this.obstaculo;
        }
    }

    
}
