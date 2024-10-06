using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Notas objNotas = new Notas();

            string[] notasString =
            {
                tb_nota1.Text,tb_nota2.Text, tb_nota3.Text 
            };

            objNotas.setNotas(notasString);

            objNotas.calcularPromedio();

            tb_promedio.Text = objNotas.getPromedio().ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            tb_nota1.Text = "";
            tb_nota2.Text = "";
            tb_nota3.Text = "";
            tb_promedio.Text = "";
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
