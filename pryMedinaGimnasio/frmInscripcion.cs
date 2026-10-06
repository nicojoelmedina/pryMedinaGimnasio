using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace pryMedinaGimnasio
{
    public partial class frmInscripcion : Form
    {
        private const decimal PRECIO_MUSCULACION = 15000m;
        private const decimal PRECIO_FUNCIONAL = 18000m;
        private const decimal PRECIO_NATACION = 22000m;

        private const decimal PRECIO_CASILLERO = 3000m;

        private const int EDAD_MINIMA = 14;

        private const decimal DESCUENTO_MENOR = 0.25m;
        private const decimal DESCUENTO_MAYOR = 0.30m;
        private const decimal DESCUENTO_ESTUDIANTE = 0.15m;

        private const decimal DESCUENTO_EFECTIVO = 0.10m;

        private const decimal RECARGO_3_CUOTAS = 0.10m;
        private const decimal RECARGO_6_CUOTAS = 0.20m;
        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void EstadoInicial()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtMeses.Text = "1";

            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;

            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;

            rbtEfectivo.Checked = true;
            rbtTarjeta.Checked = false;

            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;

            btnCalcular.Enabled = false;

            txtNombre.Focus();
        }


        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = "";
            string plan = "";
            string horario = "";

            int edad = 0;
            int meses = 0;
            int cuotas = 0;

            decimal precioMensual = 0m;
            decimal subtotal = 0m;
            decimal porcentajeDescuento = 0m;
            decimal porcentajeAjuste = 0m;
            decimal total = 0m;
            decimal valorCuota = 0m;

            nombre = txtNombre.Text;
            edad = int.Parse(txtEdad.Text);
            meses = int.Parse(txtMeses.Text);

            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("La edad mínima para inscribirse es de 14 años.");
                return;
            }

            if (meses < 1 || meses > 12)
            {
                MessageBox.Show("La cantidad de meses debe estar entre 1 y 12.");
                return;
            }

            plan = cboPlan.Text;

            switch (plan)
            {
                case "Musculación":
                    precioMensual = PRECIO_MUSCULACION;
                    break;

                case "Funcional":
                    precioMensual = PRECIO_FUNCIONAL;
                    break;

                case "Natación":
                    precioMensual = PRECIO_NATACION;
                    break;

                default:
                    MessageBox.Show("Plan inválido.");
                    return;
            }

            switch (cboTurno.SelectedIndex)
            {
                case 0:
                    horario = "Mañana (7 a 12 h)";
                    break;

                case 1:
                    horario = "Tarde (14 a 18 h)";
                    break;

                case 2:
                    horario = "Noche (18 a 23 h)";
                    break;

                default:
                    MessageBox.Show("Turno inválido.");
                    return;
            }

            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;

            subtotal = precioMensual * meses;

            if (edad < 18)
            {
                porcentajeDescuento = DESCUENTO_MENOR;
            }
            else
            {
                if (edad >= 65)
                {
                    porcentajeDescuento = DESCUENTO_MAYOR;
                }
                else
                {
                    if (chkEstudiante.Checked)
                    {
                        porcentajeDescuento = DESCUENTO_ESTUDIANTE;
                    }
                    else
                    {
                        porcentajeDescuento = 0m;
                    }
                }
            }

            subtotal = subtotal - (subtotal * porcentajeDescuento);

            if (rbtEfectivo.Checked)
            {
                porcentajeAjuste = -DESCUENTO_EFECTIVO;
            }
            else
            {
                cuotas = int.Parse(cboCuotas.Text);

                if (cuotas == 1)
                {
                    porcentajeAjuste = 0m;
                }
                else if (cuotas == 3)
                {
                    porcentajeAjuste = RECARGO_3_CUOTAS;
                }
                else if (cuotas == 6)
                {
                    porcentajeAjuste = RECARGO_6_CUOTAS;
                }
            }

            total = subtotal + (subtotal * porcentajeAjuste);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtEdad.Text != "" && txtMeses.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0;
            }
            else
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1;
            }
        }

        



    }
}
