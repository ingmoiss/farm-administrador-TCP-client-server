
namespace AplicacionServidor
{
    partial class frmAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnimal));
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtIdAnimal = new System.Windows.Forms.TextBox();
            this.lblIdAnimal = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.txtMadre = new System.Windows.Forms.TextBox();
            this.lblMadre = new System.Windows.Forms.Label();
            this.txtPadre = new System.Windows.Forms.TextBox();
            this.lblPadre = new System.Windows.Forms.Label();
            this.lblFinca = new System.Windows.Forms.Label();
            this.cbxFincas = new System.Windows.Forms.ComboBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.cbxRazas = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(165, 9);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(146, 17);
            this.lblFecha.TabIndex = 27;
            this.lblFecha.Text = "Fecha de Nacimiento";
            // 
            // txtIdAnimal
            // 
            this.txtIdAnimal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAnimal.Location = new System.Drawing.Point(9, 30);
            this.txtIdAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdAnimal.Name = "txtIdAnimal";
            this.txtIdAnimal.Size = new System.Drawing.Size(138, 25);
            this.txtIdAnimal.TabIndex = 26;
            this.txtIdAnimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdAnimal_KeyPress);
            // 
            // lblIdAnimal
            // 
            this.lblIdAnimal.AutoSize = true;
            this.lblIdAnimal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAnimal.Location = new System.Drawing.Point(6, 9);
            this.lblIdAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdAnimal.Name = "lblIdAnimal";
            this.lblIdAnimal.Size = new System.Drawing.Size(139, 17);
            this.lblIdAnimal.TabIndex = 25;
            this.lblIdAnimal.Text = "Identificación Animal";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(168, 30);
            this.dtpNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(138, 25);
            this.dtpNacimiento.TabIndex = 28;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(165, 68);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 17);
            this.lblSexo.TabIndex = 31;
            this.lblSexo.Text = "Sexo";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(9, 88);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 25);
            this.txtNombre.TabIndex = 30;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 17);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre";
            // 
            // cbxSexo
            // 
            this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Hembra",
            "Macho"});
            this.cbxSexo.Location = new System.Drawing.Point(168, 88);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(138, 25);
            this.cbxSexo.TabIndex = 32;
            // 
            // txtMadre
            // 
            this.txtMadre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMadre.Location = new System.Drawing.Point(168, 145);
            this.txtMadre.Name = "txtMadre";
            this.txtMadre.Size = new System.Drawing.Size(138, 25);
            this.txtMadre.TabIndex = 36;
            this.txtMadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMadre_KeyPress);
            // 
            // lblMadre
            // 
            this.lblMadre.AutoSize = true;
            this.lblMadre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadre.Location = new System.Drawing.Point(165, 125);
            this.lblMadre.Name = "lblMadre";
            this.lblMadre.Size = new System.Drawing.Size(136, 17);
            this.lblMadre.TabIndex = 35;
            this.lblMadre.Text = "Identificación Madre";
            // 
            // txtPadre
            // 
            this.txtPadre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPadre.Location = new System.Drawing.Point(9, 145);
            this.txtPadre.Name = "txtPadre";
            this.txtPadre.Size = new System.Drawing.Size(138, 25);
            this.txtPadre.TabIndex = 34;
            this.txtPadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPadre_KeyPress);
            // 
            // lblPadre
            // 
            this.lblPadre.AutoSize = true;
            this.lblPadre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPadre.Location = new System.Drawing.Point(6, 125);
            this.lblPadre.Name = "lblPadre";
            this.lblPadre.Size = new System.Drawing.Size(135, 17);
            this.lblPadre.TabIndex = 33;
            this.lblPadre.Text = "Identificación Padre";
            // 
            // lblFinca
            // 
            this.lblFinca.AutoSize = true;
            this.lblFinca.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinca.Location = new System.Drawing.Point(6, 182);
            this.lblFinca.Name = "lblFinca";
            this.lblFinca.Size = new System.Drawing.Size(44, 17);
            this.lblFinca.TabIndex = 37;
            this.lblFinca.Text = "Finca";
            // 
            // cbxFincas
            // 
            this.cbxFincas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFincas.FormattingEnabled = true;
            this.cbxFincas.Items.AddRange(new object[] {
            "Hembra",
            "Macho"});
            this.cbxFincas.Location = new System.Drawing.Point(9, 202);
            this.cbxFincas.Name = "cbxFincas";
            this.cbxFincas.Size = new System.Drawing.Size(297, 25);
            this.cbxFincas.TabIndex = 38;
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaza.Location = new System.Drawing.Point(6, 239);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(43, 17);
            this.lblRaza.TabIndex = 39;
            this.lblRaza.Text = "Raza";
            // 
            // cbxRazas
            // 
            this.cbxRazas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRazas.FormattingEnabled = true;
            this.cbxRazas.Location = new System.Drawing.Point(9, 259);
            this.cbxRazas.Name = "cbxRazas";
            this.cbxRazas.Size = new System.Drawing.Size(297, 25);
            this.cbxRazas.TabIndex = 40;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(168, 299);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 32);
            this.btnSalir.TabIndex = 42;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(9, 299);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(138, 32);
            this.btnRegistrar.TabIndex = 41;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(317, 345);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbxRazas);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.cbxFincas);
            this.Controls.Add(this.lblFinca);
            this.Controls.Add(this.txtMadre);
            this.Controls.Add(this.lblMadre);
            this.Controls.Add(this.txtPadre);
            this.Controls.Add(this.lblPadre);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtIdAnimal);
            this.Controls.Add(this.lblIdAnimal);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Animal";
            this.Load += new System.EventHandler(this.frmAnimal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtIdAnimal;
        private System.Windows.Forms.Label lblIdAnimal;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.TextBox txtMadre;
        private System.Windows.Forms.Label lblMadre;
        private System.Windows.Forms.TextBox txtPadre;
        private System.Windows.Forms.Label lblPadre;
        private System.Windows.Forms.Label lblFinca;
        private System.Windows.Forms.ComboBox cbxFincas;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.ComboBox cbxRazas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
    }
}