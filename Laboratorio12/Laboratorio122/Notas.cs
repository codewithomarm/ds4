using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio122
{
    internal class Notas
    {
        // Atributos
        private double[] notas;
        private double promedio;

        // Constructor
        public Notas() { }

        // Getters y Setters
        public double[] getNotas()
        {
            return notas;
        }

        public void setNotas(string[] notas)
        {
            double[] notasDouble = new double[notas.Length];
            
            for (int i=0; i<notas.Length; i++)
            {
                notasDouble[i] = Double.Parse(notas[i]);
            }

            this.notas = notasDouble;
        }

        public double getPromedio()
        {
            return promedio;
        }

        public void calcularPromedio()
        {
            int cantidadNotas = notas.Length;
            double totalNotas = 0;

            foreach (double nota in notas)
            {
                totalNotas += nota;
            }

            this.promedio = Math.Round((totalNotas / cantidadNotas), 2);
        }
    }
}
