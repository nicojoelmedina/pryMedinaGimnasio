namespace pryMedinaGimnasio
{
    partial class frmInicio
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
            lblInicio = new Label();
            btnRegistro = new Button();
            SuspendLayout();
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(127, 84);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(99, 15);
            lblInicio.TabIndex = 0;
            lblInicio.Text = "GIMNASIO SIGLO";
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(138, 137);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(75, 23);
            btnRegistro.TabIndex = 1;
            btnRegistro.Text = "Inscribirse";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 281);
            Controls.Add(btnRegistro);
            Controls.Add(lblInicio);
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInicio";
            Load += frmInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInicio;
        private Button btnRegistro;
    }
}