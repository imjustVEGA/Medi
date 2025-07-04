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

namespace MediVax
{
    public partial class VacReg : Form
    {
        public VacReg()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string dosis = txtdosis.Text;
            string previene = txtprev.Text;
            string fechaAplicada = timepick.Value.ToString("yyyy-MM-dd");
            Consulta consulta = new Consulta();
            
            string tabla = "vacuna"; 
            string campos = "Nombre, Dosis, Previene, FechaAplic";
            string valores = $"'{nombre}', '{dosis}', '{previene}', '{fechaAplicada}'";
            
            try
            {
                consulta.agregar(tabla, campos, valores);
                MessageBox.Show("Datos registrados exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar datos: {ex.Message}");
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void panel1_Paint(object sender, EventArgs e)
        {
            
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }

}
