namespace pryZarateSintepartSRL
{
    partial class frmSintepart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSintepart));
            lblUsuario = new Label();
            lblContraseña = new Label();
            lblModulo = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            bnAceptar = new Button();
            BtnCancelar = new Button();
            panel1 = new Panel();
            cmbModulo = new ComboBox();
            lblLogin = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Nirmala UI", 11.25F);
            lblUsuario.Location = new Point(79, 88);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Nirmala UI", 11.25F);
            lblContraseña.Location = new Point(79, 129);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Nirmala UI", 11.25F);
            lblModulo.Location = new Point(80, 180);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(61, 20);
            lblModulo.TabIndex = 2;
            lblModulo.Text = "Modulo";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.ForeColor = SystemColors.MenuHighlight;
            txtUsuario.Location = new Point(168, 86);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.ForeColor = SystemColors.MenuHighlight;
            txtContraseña.Location = new Point(168, 129);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '#';
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 4;
            // 
            // bnAceptar
            // 
            bnAceptar.BackColor = Color.Tan;
            bnAceptar.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bnAceptar.ForeColor = SystemColors.ActiveCaptionText;
            bnAceptar.Location = new Point(359, 88);
            bnAceptar.Name = "bnAceptar";
            bnAceptar.Size = new Size(106, 38);
            bnAceptar.TabIndex = 6;
            bnAceptar.Text = "Aceptar";
            bnAceptar.UseVisualStyleBackColor = false;
            bnAceptar.Click += bnAceptar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCancelar.Location = new Point(359, 153);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(106, 38);
            BtnCancelar.TabIndex = 7;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(cmbModulo);
            panel1.Location = new Point(66, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 214);
            panel1.TabIndex = 8;
            // 
            // cmbModulo
            // 
            cmbModulo.FormattingEnabled = true;
            cmbModulo.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
            cmbModulo.Location = new Point(102, 128);
            cmbModulo.Name = "cmbModulo";
            cmbModulo.Size = new Size(121, 23);
            cmbModulo.TabIndex = 10;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.AntiqueWhite;
            lblLogin.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(77, 35);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(59, 25);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // frmSintepart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(623, 317);
            Controls.Add(lblLogin);
            Controls.Add(BtnCancelar);
            Controls.Add(bnAceptar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblModulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSintepart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sintepart";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblModulo;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button bnAceptar;
        private Button BtnCancelar;
        private Panel panel1;
        private Label lblLogin;
        private ComboBox cmbModulo;
    }
}