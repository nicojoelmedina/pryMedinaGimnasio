using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryMedinaGimnasio
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmInscripcion inscripcion = new frmInscripcion();
            inscripcion.Show();

            this.Hide();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
