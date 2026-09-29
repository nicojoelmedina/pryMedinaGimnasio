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
            SuspendLayout();
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(337, 62);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(81, 19);
            chkEstudiante.TabIndex = 0;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 58);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(214, 58);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 2;
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            cboPlan.Location = new Point(76, 121);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(121, 23);
            cboPlan.TabIndex = 3;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new Point(73, 169);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(121, 23);
            cboTurno.TabIndex = 4;
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(78, 288);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(145, 19);
            chkCasillero.TabIndex = 5;
            chkCasillero.Text = "Casillero ($ 3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(78, 220);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(100, 23);
            txtMeses.TabIndex = 6;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(78, 330);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 7;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(78, 365);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 8;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(76, 401);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(121, 23);
            cboCuotas.TabIndex = 9;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(308, 347);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(308, 395);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 61);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(175, 61);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 13;
            lblEdad.Text = "Edad:";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(12, 124);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(49, 15);
            lblPlan.TabIndex = 15;
            lblPlan.Text = "Plan  ->";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(12, 172);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(55, 15);
            lblTurno.TabIndex = 16;
            lblTurno.Text = "Turno ->";
            // 
            // gbxDatosPersonales
            // 
            gbxDatosPersonales.Location = new Point(8, 15);
            gbxDatosPersonales.Name = "gbxDatosPersonales";
            gbxDatosPersonales.Size = new Size(431, 100);
            gbxDatosPersonales.TabIndex = 17;
            gbxDatosPersonales.TabStop = false;
            gbxDatosPersonales.Text = "Datos Personales";
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(16, 223);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(56, 15);
            lblMeses.TabIndex = 18;
            lblMeses.Text = "Meses ->";
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMeses);
            Controls.Add(lblTurno);
            Controls.Add(lblPlan);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(cboCuotas);
            Controls.Add(rbtTarjeta);
            Controls.Add(rbtEfectivo);
            Controls.Add(txtMeses);
            Controls.Add(chkCasillero);
            Controls.Add(cboTurno);
            Controls.Add(cboPlan);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(chkEstudiante);
            Controls.Add(gbxDatosPersonales);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción";
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
    }
}