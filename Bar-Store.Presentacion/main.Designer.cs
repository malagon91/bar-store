namespace Bar_Store.Presentacion
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtOpcion = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmdSalir);
            this.panel1.Controls.Add(this.cmdBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 450);
            this.panel1.TabIndex = 1;
            // 
            // cmdSalir
            // 
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdSalir.Location = new System.Drawing.Point(19, 485);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(64, 70);
            this.cmdSalir.TabIndex = 3;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdSalir.UseVisualStyleBackColor = true;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdBuscar.Location = new System.Drawing.Point(19, 14);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(64, 70);
            this.cmdBuscar.TabIndex = 0;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // txtOpcion
            // 
            this.txtOpcion.BackColor = System.Drawing.Color.SkyBlue;
            this.txtOpcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtOpcion.Location = new System.Drawing.Point(100, 0);
            this.txtOpcion.Name = "txtOpcion";
            this.txtOpcion.ReadOnly = true;
            this.txtOpcion.Size = new System.Drawing.Size(700, 20);
            this.txtOpcion.TabIndex = 4;
            this.txtOpcion.Text = "Menu Principal de la tienda";
            this.txtOpcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(100, 20);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(700, 430);
            this.panel.TabIndex = 5;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.txtOpcion);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M E N U    P R I N C I P A L ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdBuscar;
        public System.Windows.Forms.TextBox txtOpcion;
        private System.Windows.Forms.Panel panel;
    }
}