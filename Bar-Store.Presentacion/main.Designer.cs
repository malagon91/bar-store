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
            this.txtOpcion = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.bQuerty = new System.Windows.Forms.Button();
            this.bUsers = new System.Windows.Forms.Button();
            this.bInventory = new System.Windows.Forms.Button();
            this.bProducts = new System.Windows.Forms.Button();
            this.bSales = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bQuerty);
            this.panel1.Controls.Add(this.bUsers);
            this.panel1.Controls.Add(this.bInventory);
            this.panel1.Controls.Add(this.bProducts);
            this.panel1.Controls.Add(this.cmdSalir);
            this.panel1.Controls.Add(this.bSales);
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
            // bQuerty
            // 
            this.bQuerty.Image = global::Bar_Store.Presentacion.Properties.Resources.atm;
            this.bQuerty.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bQuerty.Location = new System.Drawing.Point(19, 150);
            this.bQuerty.Name = "bQuerty";
            this.bQuerty.Size = new System.Drawing.Size(64, 57);
            this.bQuerty.TabIndex = 7;
            this.bQuerty.Text = "Teclado";
            this.bQuerty.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bQuerty.UseVisualStyleBackColor = true;
            this.bQuerty.Click += new System.EventHandler(this.bQuerty_Click);
            // 
            // bUsers
            // 
            this.bUsers.Image = global::Bar_Store.Presentacion.Properties.Resources.report_user;
            this.bUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bUsers.Location = new System.Drawing.Point(19, 282);
            this.bUsers.Name = "bUsers";
            this.bUsers.Size = new System.Drawing.Size(64, 57);
            this.bUsers.TabIndex = 6;
            this.bUsers.Text = "Usuarios";
            this.bUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bUsers.UseVisualStyleBackColor = true;
            this.bUsers.Click += new System.EventHandler(this.bUsers_Click);
            // 
            // bInventory
            // 
            this.bInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInventory.Image = global::Bar_Store.Presentacion.Properties.Resources.book;
            this.bInventory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bInventory.Location = new System.Drawing.Point(19, 215);
            this.bInventory.Name = "bInventory";
            this.bInventory.Size = new System.Drawing.Size(64, 56);
            this.bInventory.TabIndex = 5;
            this.bInventory.Text = "Inventarios";
            this.bInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bInventory.UseVisualStyleBackColor = true;
            this.bInventory.Click += new System.EventHandler(this.bInventory_Click);
            // 
            // bProducts
            // 
            this.bProducts.Image = global::Bar_Store.Presentacion.Properties.Resources.application_from_storage;
            this.bProducts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bProducts.Location = new System.Drawing.Point(19, 87);
            this.bProducts.Name = "bProducts";
            this.bProducts.Size = new System.Drawing.Size(64, 57);
            this.bProducts.TabIndex = 4;
            this.bProducts.Text = "Productos";
            this.bProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bProducts.UseVisualStyleBackColor = true;
            this.bProducts.Click += new System.EventHandler(this.bProducts_Click);
            // 
            // bSales
            // 
            this.bSales.Image = global::Bar_Store.Presentacion.Properties.Resources.basket;
            this.bSales.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bSales.Location = new System.Drawing.Point(19, 14);
            this.bSales.Name = "bSales";
            this.bSales.Size = new System.Drawing.Size(64, 57);
            this.bSales.TabIndex = 0;
            this.bSales.Text = "Ventas";
            this.bSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bSales.UseVisualStyleBackColor = true;
            this.bSales.Click += new System.EventHandler(this.bSales_Click);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.Button bSales;
        public System.Windows.Forms.TextBox txtOpcion;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button bProducts;
        private System.Windows.Forms.Button bInventory;
        private System.Windows.Forms.Button bUsers;
        private System.Windows.Forms.Button bQuerty;
    }
}