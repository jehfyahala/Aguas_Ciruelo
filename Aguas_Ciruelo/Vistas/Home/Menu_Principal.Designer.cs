namespace Aguas_Ciruelo.Vistas.Home
{
    partial class Menu_Principal
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
            this.lblPAgos = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lblPrecios = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnPrecios = new System.Windows.Forms.PictureBox();
            this.BtnClientes = new System.Windows.Forms.PictureBox();
            this.BtnUsuarios = new System.Windows.Forms.PictureBox();
            this.btnPagos = new System.Windows.Forms.PictureBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.btnCerrarSesion = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPrecios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPagos)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPAgos
            // 
            this.lblPAgos.AutoSize = true;
            this.lblPAgos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPAgos.Location = new System.Drawing.Point(106, 226);
            this.lblPAgos.Name = "lblPAgos";
            this.lblPAgos.Size = new System.Drawing.Size(46, 19);
            this.lblPAgos.TabIndex = 6;
            this.lblPAgos.Text = "Pagos";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(377, 226);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(57, 19);
            this.lblClientes.TabIndex = 7;
            this.lblClientes.Text = "Clientes";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(98, 477);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(62, 19);
            this.lblUsuarios.TabIndex = 8;
            this.lblUsuarios.Text = "Usuarios";
            // 
            // lblPrecios
            // 
            this.lblPrecios.AutoSize = true;
            this.lblPrecios.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecios.Location = new System.Drawing.Point(378, 477);
            this.lblPrecios.Name = "lblPrecios";
            this.lblPrecios.Size = new System.Drawing.Size(54, 19);
            this.lblPrecios.TabIndex = 9;
            this.lblPrecios.Text = "Precios";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(558, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel1.Text = "Bienvenido(a):";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel2.Text = "Usuario";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // BtnPrecios
            // 
            this.BtnPrecios.Image = global::Aguas_Ciruelo.Properties.Resources.Precios;
            this.BtnPrecios.Location = new System.Drawing.Point(310, 284);
            this.BtnPrecios.Name = "BtnPrecios";
            this.BtnPrecios.Size = new System.Drawing.Size(190, 190);
            this.BtnPrecios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnPrecios.TabIndex = 3;
            this.BtnPrecios.TabStop = false;
            this.BtnPrecios.Click += new System.EventHandler(this.BtnPrecios_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Image = global::Aguas_Ciruelo.Properties.Resources.Clientes;
            this.BtnClientes.Location = new System.Drawing.Point(310, 34);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(190, 190);
            this.BtnClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClientes.TabIndex = 2;
            this.BtnClientes.TabStop = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Image = global::Aguas_Ciruelo.Properties.Resources.Empleados;
            this.BtnUsuarios.Location = new System.Drawing.Point(34, 284);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(190, 190);
            this.BtnUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnUsuarios.TabIndex = 1;
            this.BtnUsuarios.TabStop = false;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Image = global::Aguas_Ciruelo.Properties.Resources.Pagos;
            this.btnPagos.Location = new System.Drawing.Point(34, 34);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(190, 190);
            this.btnPagos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPagos.TabIndex = 0;
            this.btnPagos.TabStop = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCerrarSesion});
            this.statusStrip2.Location = new System.Drawing.Point(0, 520);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(558, 22);
            this.statusStrip2.TabIndex = 11;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Image = global::Aguas_Ciruelo.Properties.Resources.forceexit_103817;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(92, 17);
            this.btnCerrarSesion.Text = "&Cerrar Sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(558, 542);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblPrecios);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblPAgos);
            this.Controls.Add(this.BtnPrecios);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.BtnUsuarios);
            this.Controls.Add(this.btnPagos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Principal";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPrecios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPagos)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnPagos;
        private System.Windows.Forms.PictureBox BtnUsuarios;
        private System.Windows.Forms.PictureBox BtnPrecios;
        private System.Windows.Forms.PictureBox BtnClientes;
        private System.Windows.Forms.Label lblPAgos;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblPrecios;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel btnCerrarSesion;
    }
}