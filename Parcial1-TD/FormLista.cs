using BLL.Implementations;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_TD
{
    public partial class FormLista : Form
    {
        public FormLista()
        {
            InitializeComponent();
        }

        private List<Mision> misiones = new List<Mision>();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
               misiones = MisionBLL.Current.BuscarMisiones(DateTime.Parse(dtpDesde.Text), DateTime.Parse(dtpHasta.Text));
               Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    

        private void Listar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = misiones;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();


            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaHora",
                HeaderText = "Fecha y Hora"
            });

            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "ValorSensor1",
                HeaderText = "Sensor 1"
            });

            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "ValorSensor2",
                HeaderText = "Sensor 2"
            });

        }



    }
}
