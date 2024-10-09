using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio131
{
    public partial class Form1 : Form
    {
        string connectionString = 
            @"Server=.\sqlexpress2;
                Database=Northwind;
                TrustServerCertificate=true;
                Integrated Security=SSPI;";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);

            try
            {
                conexion.Open();
                MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");

                string consulta = "select ProductName from [dbo].[Products]";

                SqlCommand comando = new SqlCommand(consulta, conexion);

                SqlDataReader lector = comando.ExecuteReader();

                listBox1.Text = "";

                while (lector.Read())
                {
                    // Acceder a los valores de las columnas por índice o por nombre
                    string nombreProducto = lector["ProductName"].ToString();
                    listBox1.Items.Add(nombreProducto);
                }

                // Cerrar el lector
                lector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conexion.Close();
                MessageBox.Show("Se cerró la conexión.");
            }
        }
    }
}
