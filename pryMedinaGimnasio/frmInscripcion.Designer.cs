namespace pryMedinaGimnasio
{
    partial class frmInscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chkEstudiante = new CheckBox();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            cboPlan = new ComboBox();
            cboTurno = new ComboBox();
            chkCasillero = new CheckBox();
            txtMeses = new TextBox();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            cboCuotas = new ComboBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            lblNombre = new Label();
            lblEdad = new Label();
            lblPlan = new Label();
            lblTurno = new Label();
            gbxDatosPersonales = new GroupBox();
            lblMeses = new Label();
            gbxPlan = new GroupBox();
            lblCuotas = new Label();
            gbxPago = new GroupBox();
            gbxPlan.SuspendLayout();
            gbxPago.SuspendLayout();
            SuspendLayout();
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(337, 62);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(81, 19);
            chkEstudiante.TabIndex = 2;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 58);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(214, 58);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 1;
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            cboPlan.Location = new Point(61, 19);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(121, 23);
            cboPlan.TabIndex = 1;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new Point(263, 21);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(121, 23);
            cboTurno.TabIndex = 5;
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(202, 59);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(145, 19);
            chkCasillero.TabIndex = 6;
            chkCasillero.Text = "Casillero ($ 3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(68, 55);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(114, 23);
            txtMeses.TabIndex = 3;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(55, 22);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(55, 54);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(203, 19);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(121, 23);
            cboCuotas.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(364, 286);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(364, 251);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 61);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(175, 61);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad:";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(5, 24);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(49, 15);
            lblPlan.TabIndex = 0;
            lblPlan.Text = "Plan  ->";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(202, 24);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(55, 15);
            lblTurno.TabIndex = 4;
            lblTurno.Text = "Turno ->";
            // 
            // gbxDatosPersonales
            // 
            gbxDatosPersonales.Location = new Point(8, 15);
            gbxDatosPersonales.Name = "gbxDatosPersonales";
            gbxDatosPersonales.Size = new Size(431, 100);
            gbxDatosPersonales.TabIndex = 0;
            gbxDatosPersonales.TabStop = false;
            gbxDatosPersonales.Text = "Datos Personales";
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(6, 58);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(56, 15);
            lblMeses.TabIndex = 2;
            lblMeses.Text = "Meses ->";
            // 
            // gbxPlan
            // 
            gbxPlan.Controls.Add(lblTurno);
            gbxPlan.Controls.Add(lblMeses);
            gbxPlan.Controls.Add(lblPlan);
            gbxPlan.Controls.Add(txtMeses);
            gbxPlan.Controls.Add(cboPlan);
            gbxPlan.Controls.Add(cboTurno);
            gbxPlan.Controls.Add(chkCasillero);
            gbxPlan.Location = new Point(8, 121);
            gbxPlan.Name = "gbxPlan";
            gbxPlan.Size = new Size(427, 93);
            gbxPlan.TabIndex = 2;
            gbxPlan.TabStop = false;
            gbxPlan.Text = "Plan";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(137, 22);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(60, 15);
            lblCuotas.TabIndex = 2;
            lblCuotas.Text = "Cuotas ->";
            // 
            // gbxPago
            // 
            gbxPago.Controls.Add(lblCuotas);
            gbxPago.Controls.Add(cboCuotas);
            gbxPago.Controls.Add(rbtTarjeta);
            gbxPago.Controls.Add(rbtEfectivo);
            gbxPago.Location = new Point(14, 232);
            gbxPago.Name = "gbxPago";
            gbxPago.Size = new Size(341, 91);
            gbxPago.TabIndex = 3;
            gbxPago.TabStop = false;
            gbxPago.Text = "Pago";
            // 
            // frmInscripcion
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 342);
            Controls.Add(lblEdad);
            Controls.Add(btnCalcular);
            Controls.Add(lblNombre);
            Controls.Add(btnLimpiar);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(chkEstudiante);
            Controls.Add(gbxDatosPersonales);
            Controls.Add(gbxPlan);
            Controls.Add(gbxPago);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción";
            Load += frmInscripcion_Load;
            gbxPlan.ResumeLayout(false);
            gbxPlan.PerformLayout();
            gbxPago.ResumeLayout(false);
            gbxPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkEstudiante;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private ComboBox cboPlan;
        private ComboBox cboTurno;
        private CheckBox chkCasillero;
        private TextBox txtMeses;
        private RadioButton rbtEfectivo;
        private RadioButton rbtTarjeta;
        private ComboBox cboCuotas;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label lblNombre;
        private Label lblEdad;
        private Label lblPlan;
        private Label lblTurno;
        private GroupBox gbxDatosPersonales;
        private Label lblMeses;
        private GroupBox gbxPlan;
        private Label lblCuotas;
        private GroupBox gbxPago;
    }
}