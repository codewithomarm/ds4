using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_semiperimetro_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo();

            string[] lados = { tb_ladoA.Text, tb_ladoB.Text, tb_ladoC.Text };

            triangulo.setLados(lados);

            triangulo.calcularSemiperimetro();

            tb_semiperimetro.Text = triangulo.getSemiperimetro().ToString();
        }

        private void btn_area_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo();

            string[] lados = { tb_ladoA.Text, tb_ladoB.Text, tb_ladoC.Text };

            triangulo.setLados(lados);

            triangulo.calcularArea();

            tb_area.Text = triangulo.getArea().ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            tb_ladoA.Text = "";
            tb_ladoB.Text = "";
            tb_ladoC.Text = "";
            tb_semiperimetro.Text = "";
            tb_area.Text = "";
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
