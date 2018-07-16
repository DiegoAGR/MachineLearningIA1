using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laberinto
{
    class Agente
    {
        private string Nombre;
        private double esfProm;
        private double Max_E;
        private double Min_E;
        private double esfTrayecto;
        private double Ajuste;
        private bool estado;
        private int entrenamiento;
        private int entrenamientos;
        private List<Paso> Recorrido = new List<Paso>();
        int[] terrenos = { 0,0,0,0};

        
        //Control visitados

        public Agente(string n,int e)
        {
            this.Nombre = n;
            esfTrayecto = 0;
            entrenamiento = e;
        }

        public void setRecorrido(List<Paso> r)
        {
            this.Recorrido = r;
        }

        public void actualizarEntr()
        {
            this.entrenamientos++;
        }
        public List<Paso> getRecorrido()
        {
            return this.Recorrido;
        }

        public string getNombre()
        {
            return this.Nombre;
        }

        public bool getEstado()
        {
            return this.estado;
        }

        public double getAjuste()
        {
            return this.Ajuste;
        }

      
        public void CalcularEsfuerzoTotal()
        {
            esfTrayecto = 0;
            terrenos[0] = 0;
            terrenos[1] = 0;
            terrenos[2] = 0;
            terrenos[3] = 0;


            for (int i = 0; i < Recorrido.Count; i++)
            {
                esfTrayecto += Recorrido[i].getPeso();

                switch (Recorrido[i].getTipo())
                {
                    case "Montana":
                        terrenos[0]++;
                        break;

                    case "Agua":
                        terrenos[1]++;
                        break;
                    case "Barranco":
                        terrenos[2]++;
                        break;
                    case "Plano":
                        terrenos[3]++;
                        break;
                }
            }
            ActualizarDatos();
        }


        void ActualizarDatos()
        {
            Ajuste = 0;
            if (entrenamientos == 0)
            {
                Max_E = esfTrayecto;
                Min_E = esfTrayecto;
            }

            esfProm = ( Max_E + Min_E ) / 2;
            Ajuste = esfTrayecto - esfProm;
            
            if(esfTrayecto>Max_E)
            {
                Max_E = esfTrayecto;
            }
            else
            {
                Min_E = esfTrayecto;
            }

        }

        public void MostrarDatosRecorrido()
        {
            //CalcularEsfuerzoTotal();
            
            System.Windows.Forms.MessageBox.Show("Pasos: " + Recorrido.Count.ToString() + " Esfuerzo total: " + esfTrayecto.ToString() + "\n" + "Montana: " + terrenos[0].ToString()
                + " Agua: " + terrenos[1].ToString() + " Barranco: " + terrenos[2].ToString() + " Plano: " + terrenos[3].ToString() + "\n"+
                "Esfuerzo Maximo: "+Max_E.ToString()+" Esfuerzo Minimo: " +Min_E.ToString() +" Ajuste:"+ Ajuste.ToString());
            


        }
    }
}
