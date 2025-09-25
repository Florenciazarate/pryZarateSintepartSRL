namespace pryZarateSintepartSRL
{
    partial class frmBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenida));
            lblBienenido = new Label();
            btnIngresar = new Button();
            lblIngresarSistema = new Label();
            lblSintepart = new Label();
            SuspendLayout();
            // 
            // lblBienenido
            // 
            lblBienenido.AutoSize = true;
            lblBienenido.Font = new Font("Nirmala UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienenido.Location = new Point(138, 70);
            lblBienenido.Name = "lblBienenido";
            lblBienenido.Size = new Size(189, 40);
            lblBienenido.TabIndex = 0;
            lblBienenido.Text = "Bienvenido a ";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Bisque;
            btnIngresar.Font = new Font("Nirmala Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(248, 133);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(88, 36);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblIngresarSistema
            // 
            lblIngresarSistema.AutoSize = true;
            lblIngresarSistema.Font = new Font("Nirmala Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngresarSistema.Location = new Point(204, 110);
            lblIngresarSistema.Name = "lblIngresarSistema";
            lblIngresarSistema.Size = new Size(194, 17);
            lblIngresarSistema.TabIndex = 2;
            lblIngresarSistema.Text = "Presione el botón para ingresar";
            // 
            // lblSintepart
            // 
            lblSintepart.AutoSize = true;
            lblSintepart.Font = new Font("Nirmala Text", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSintepart.Location = new Point(313, 70);
            lblSintepart.Name = "lblSintepart";
            lblSintepart.Size = new Size(144, 40);
            lblSintepart.TabIndex = 3;
            lblSintepart.Text = "Sintepart";
            // 
            // frmBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(621, 298);
            Controls.Add(lblSintepart);
            Controls.Add(lblIngresarSistema);
            Controls.Add(btnIngresar);
            Controls.Add(lblBienenido);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienenido;
        private Button btnIngresar;
        private Label lblIngresarSistema;
        private Label lblSintepart;
    }
}