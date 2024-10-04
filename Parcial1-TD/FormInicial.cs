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
    public partial class FormInicial : Form
    {

        private Form activeForm;

        public FormInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form1());
        }

        public void AbrirForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCont.Controls.Add(childForm);
            panelCont.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormLista());
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            AbrirForm(new Form1());
        }
    }
}
