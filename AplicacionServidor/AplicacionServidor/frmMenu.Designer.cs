
namespace AplicacionServidor
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lstBitacora = new System.Windows.Forms.ListView();
            this.lblBitacora = new System.Windows.Forms.Label();
            this.btnFinca = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVacuna = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnRegistros = new System.Windows.Forms.Button();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnRaza = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnDueno = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.plnBitacora = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlMenu.SuspendLayout();
            this.plnBitacora.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBitacora
            // 
            this.lstBitacora.HideSelection = false;
            this.lstBitacora.Location = new System.Drawing.Point(18, 40);
            this.lstBitacora.Name = "lstBitacora";
            this.lstBitacora.Size = new System.Drawing.Size(439, 272);
            this.lstBitacora.TabIndex = 0;
            this.lstBitacora.UseCompatibleStateImageBehavior = false;
            // 
            // lblBitacora
            // 
            this.lblBitacora.AutoSize = true;
            this.lblBitacora.BackColor = System.Drawing.Color.Transparent;
            this.lblBitacora.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitacora.ForeColor = System.Drawing.Color.White;
            this.lblBitacora.Location = new System.Drawing.Point(14, 14);
            this.lblBitacora.Name = "lblBitacora";
            this.lblBitacora.Size = new System.Drawing.Size(79, 22);
            this.lblBitacora.TabIndex = 1;
            this.lblBitacora.Text = "Bitacora";
            // 
            // btnFinca
            // 
            this.btnFinca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.btnFinca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinca.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinca.ForeColor = System.Drawing.Color.Black;
            this.btnFinca.Location = new System.Drawing.Point(14, 39);
            this.btnFinca.Name = "btnFinca";
            this.btnFinca.Size = new System.Drawing.Size(136, 32);
            this.btnFinca.TabIndex = 2;
            this.btnFinca.Text = "Registrar Finca";
            this.btnFinca.UseVisualStyleBackColor = false;
            this.btnFinca.Click += new System.EventHandler(this.btnFinca_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnSalir);
            this.pnlMenu.Controls.Add(this.btnVacuna);
            this.pnlMenu.Controls.Add(this.btnUsuario);
            this.pnlMenu.Controls.Add(this.btnRegistros);
            this.pnlMenu.Controls.Add(this.btnAnimal);
            this.pnlMenu.Controls.Add(this.btnRaza);
            this.pnlMenu.Controls.Add(this.btnEmpleado);
            this.pnlMenu.Controls.Add(this.btnDueno);
            this.pnlMenu.Controls.Add(this.lblMenu);
            this.pnlMenu.Controls.Add(this.btnFinca);
            this.pnlMenu.Location = new System.Drawing.Point(496, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(308, 327);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(14, 191);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(278, 32);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVacuna
            // 
            this.btnVacuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.btnVacuna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVacuna.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVacuna.Location = new System.Drawing.Point(14, 153);
            this.btnVacuna.Name = "btnVacuna";
            this.btnVacuna.Size = new System.Drawing.Size(136, 32);
            this.btnVacuna.TabIndex = 10;
            this.btnVacuna.Text = "Vacuna";
            this.btnVacuna.UseVisualStyleBackColor = false;
            this.btnVacuna.Click += new System.EventHandler(this.btnVacuna_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Location = new System.Drawing.Point(156, 153);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(136, 32);
            this.btnUsuario.TabIndex = 9;
            this.btnUsuario.Text = "Activar Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnRegistros
            // 
            this.btnRegistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.btnRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistros.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistros.Location = new System.Drawing.Point(156, 115);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(136, 32);
            this.btnRegistros.TabIndex = 8;
            this.btnRegistros.Text = "Registros";
            this.btnRegistros.UseVisualStyleBackColor = false;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.btnAnimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnimal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimal.Location = new System.Drawing.Point(14, 115);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(136, 32);
            this.btnAnimal.TabIndex = 7;
            this.btnAnimal.Text = "Registrar Animal";
            this.btnAnimal.UseVisualStyleBackColor = false;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnRaza
            // 
            this.btnRaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.btnRaza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaza.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaza.Location = new System.Drawing.Point(156, 77);
            this.btnRaza.Name = "btnRaza";
            this.btnRaza.Size = new System.Drawing.Size(136, 32);
            this.btnRaza.TabIndex = 6;
            this.btnRaza.Text = "Registrar Raza";
            this.btnRaza.UseVisualStyleBackColor = false;
            this.btnRaza.Click += new System.EventHandler(this.btnRaza_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.Location = new System.Drawing.Point(14, 77);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(136, 32);
            this.btnEmpleado.TabIndex = 5;
            this.btnEmpleado.Text = "Registrar Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnDueno
            // 
            this.btnDueno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.btnDueno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDueno.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDueno.Location = new System.Drawing.Point(156, 39);
            this.btnDueno.Name = "btnDueno";
            this.btnDueno.Size = new System.Drawing.Size(136, 32);
            this.btnDueno.TabIndex = 4;
            this.btnDueno.Text = "Registrar Dueño";
            this.btnDueno.UseVisualStyleBackColor = false;
            this.btnDueno.Click += new System.EventHandler(this.btnDueno_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(10, 14);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(56, 22);
            this.lblMenu.TabIndex = 3;
            this.lblMenu.Text = "Menú";
            // 
            // plnBitacora
            // 
            this.plnBitacora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(174)))), ((int)(((byte)(222)))));
            this.plnBitacora.Controls.Add(this.lstBitacora);
            this.plnBitacora.Controls.Add(this.lblBitacora);
            this.plnBitacora.Location = new System.Drawing.Point(12, 12);
            this.plnBitacora.Name = "plnBitacora";
            this.plnBitacora.Size = new System.Drawing.Size(474, 330);
            this.plnBitacora.TabIndex = 4;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(239)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(816, 357);
            this.Controls.Add(this.plnBitacora);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.plnBitacora.ResumeLayout(false);
            this.plnBitacora.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstBitacora;
        private System.Windows.Forms.Label lblBitacora;
        private System.Windows.Forms.Button btnFinca;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel plnBitacora;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnDueno;
        private System.Windows.Forms.Button btnVacuna;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnRegistros;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnRaza;
        private System.Windows.Forms.Button btnSalir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}