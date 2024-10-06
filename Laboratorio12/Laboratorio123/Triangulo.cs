using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio123
{
    internal class Triangulo
    {
        // Atributos
        double[] lados;
        double altura;
        double semiperimetro;
        double area;

        // Constructor
        public Triangulo() { }

        // Getter y Setters
        public double[] getLados()
        {
            return lados;
        }

        public void setLados(string[] lados)
        {
            double[] ladosDouble = new double[lados.Length];

            for(int i=0; i<lados.Length; i++)
            {
                ladosDouble[i] = Double.Parse(lados[i]);
            }

            this.lados = ladosDouble;
        }

        public double getAltura()
        {
            return altura;
        }

        public void calcularAltura()
        {
            double ladoBase = lados[2];
            double b = ladoBase / 2;
            double c = lados[0];
            double a = Math.Sqrt(((Math.Pow(c, 2)) - (Math.Pow(b, 2))));
            this.altura = a;
        }

        public double getSemiperimetro()
        {
            return semiperimetro;
        }

        public void calcularSemiperimetro()
        {
            double sumaLados = 0;

            foreach (double lado in lados)
            {
                sumaLados += lado;
            }

            semiperimetro = Math.Round((sumaLados / 2),2);
        }

        public double getArea()
        {
            return area;
        }

        public void calcularArea()
        {
            double ladoBase = lados[2];
            calcularAltura();
            this.area = Math.Round(((ladoBase * this.altura) / 2),2);
        }
    }
}
