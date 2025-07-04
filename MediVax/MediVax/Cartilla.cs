using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediVax.Consultas;
using MySql.Data.MySqlClient;

namespace MediVax
{
    public partial class Cartilla : Form
    {
        public Cartilla()
        {
            InitializeComponent();
            CargarDatosVacunas();
        }

        private void Cartilla_Load(object sender, EventArgs e)
        {

        }

        private void historialvac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
            this.Close();
        }

        private void addvac_Click(object sender, EventArgs e)
        {
            VacReg newReg = new VacReg();
            newReg.ShowDialog();
            historialvac.Refresh();
        }
        private void CargarDatosVacunas()
        {
            Consulta consulta = new Consulta();
            string query = "SELECT Nombre, Dosis, Previene, FechaAplic FROM vacuna";

            using (MySqlConnection conexion = consulta.Conectar())
            {
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    historialvac.DataSource = table;

                    historialvac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    historialvac.ReadOnly = true;
                    historialvac.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }





    }
}
