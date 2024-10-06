using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio121
{
    internal class Calculos
    {
        private double velocidad;
        private double tiempo;

        public Calculos() { }

        public double getVelocidad()
        {
            return velocidad;
        }

        public void setVelocidad(string velocidad)
        {
            double velocidadDouble = Double.Parse(velocidad);
            this.velocidad = velocidadDouble;
        }

        public double getTiempo()
        {
            return tiempo;
        }

        public void setTiempo(string tiempo)
        {
            double tiempoDouble = Double.Parse(tiempo);
            this.tiempo = tiempoDouble;
        }

        public double calcularDistanciaTotal()
        {
            double tiempoHoras = getTiempo() / 60;
            return getVelocidad() * tiempoHoras;
        }
    }
}
