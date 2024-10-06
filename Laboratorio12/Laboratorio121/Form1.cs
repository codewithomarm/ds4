using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Calculos calculos = new Calculos();
            calculos.setVelocidad(tb_velocidad.Text);
            calculos.setTiempo(tb_tiempo.Text);
            tb_resultado.Text = calculos.calcularDistanciaTotal().ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            tb_velocidad.Text = "";
            tb_tiempo.Text = "";
            tb_resultado.Text = "";
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
