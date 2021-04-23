
namespace AplicacionServidor
{
    partial class frmRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistros));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnFincas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVacunas = new System.Windows.Forms.Button();
            this.btnAnimales = new System.Windows.Forms.Button();
            this.btnRazas = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnDuennos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(174)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.dgvRegistros);
            this.panel1.Controls.Add(this.lblRegistros);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 312);
            this.panel1.TabIndex = 0;
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(17, 36);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.Size = new System.Drawing.Size(487, 260);
            this.dgvRegistros.TabIndex = 3;
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.ForeColor = System.Drawing.Color.White;
            this.lblRegistros.Location = new System.Drawing.Point(13, 11);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(92, 22);
            this.lblRegistros.TabIndex = 2;
            this.lblRegistros.Text = "Registros";
            // 
            // btnFincas
            // 
            this.btnFincas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.btnFincas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFincas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFincas.ForeColor = System.Drawing.Color.Black;
            this.btnFincas.Location = new System.Drawing.Point(34, 36);
            this.btnFincas.Name = "btnFincas";
            this.btnFincas.Size = new System.Drawing.Size(136, 32);
            this.btnFincas.TabIndex = 3;
            this.btnFincas.Text = "Mostrar Fincas";
            this.btnFincas.UseVisualStyleBackColor = false;
            this.btnFincas.Click += new System.EventHandler(this.btnFincas_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnVacunas);
            this.panel2.Controls.Add(this.btnAnimales);
            this.panel2.Controls.Add(this.btnRazas);
            this.panel2.Controls.Add(this.btnEmpleados);
            this.panel2.Controls.Add(this.btnDuennos);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnFincas);
            this.panel2.Location = new System.Drawing.Point(547, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 312);
            this.panel2.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(34, 264);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 32);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVacunas
            // 
            this.btnVacunas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.btnVacunas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVacunas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVacunas.ForeColor = System.Drawing.Color.Black;
            this.btnVacunas.Location = new System.Drawing.Point(34, 226);
            this.btnVacunas.Name = "btnVacunas";
            this.btnVacunas.Size = new System.Drawing.Size(136, 32);
            this.btnVacunas.TabIndex = 9;
            this.btnVacunas.Text = "Mostrar Vacunas";
            this.btnVacunas.UseVisualStyleBackColor = false;
            this.btnVacunas.Click += new System.EventHandler(this.btnVacunas_Click);
            // 
            // btnAnimales
            // 
            this.btnAnimales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.btnAnimales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnimales.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimales.ForeColor = System.Drawing.Color.Black;
            this.btnAnimales.Location = new System.Drawing.Point(34, 188);
            this.btnAnimales.Name = "btnAnimales";
            this.btnAnimales.Size = new System.Drawing.Size(136, 32);
            this.btnAnimales.TabIndex = 8;
            this.btnAnimales.Text = "Mostrar Animales";
            this.btnAnimales.UseVisualStyleBackColor = false;
            this.btnAnimales.Click += new System.EventHandler(this.btnAnimales_Click);
            // 
            // btnRazas
            // 
            this.btnRazas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.btnRazas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRazas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRazas.ForeColor = System.Drawing.Color.Black;
            this.btnRazas.Location = new System.Drawing.Point(34, 150);
            this.btnRazas.Name = "btnRazas";
            this.btnRazas.Size = new System.Drawing.Size(136, 32);
            this.btnRazas.TabIndex = 7;
            this.btnRazas.Text = "Mostrar Razas";
            this.btnRazas.UseVisualStyleBackColor = false;
            this.btnRazas.Click += new System.EventHandler(this.btnRazas_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.Black;
            this.btnEmpleados.Location = new System.Drawing.Point(34, 112);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(136, 32);
            this.btnEmpleados.TabIndex = 6;
            this.btnEmpleados.Text = "Mostrar Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnDuennos
            // 
            this.btnDuennos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.btnDuennos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuennos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuennos.ForeColor = System.Drawing.Color.Black;
            this.btnDuennos.Location = new System.Drawing.Point(34, 74);
            this.btnDuennos.Name = "btnDuennos";
            this.btnDuennos.Size = new System.Drawing.Size(136, 32);
            this.btnDuennos.TabIndex = 5;
            this.btnDuennos.Text = "Mostrar Dueños";
            this.btnDuennos.UseVisualStyleBackColor = false;
            this.btnDuennos.Click += new System.EventHandler(this.btnDuennos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menú";
            // 
            // frmRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(762, 337);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.frmRegistros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btnFincas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVacunas;
        private System.Windows.Forms.Button btnAnimales;
        private System.Windows.Forms.Button btnRazas;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnDuennos;
    }
}