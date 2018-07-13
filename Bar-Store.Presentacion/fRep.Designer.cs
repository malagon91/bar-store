namespace Bar_Store.Presentacion
{
    partial class fRep
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
            this.pTop = new System.Windows.Forms.Panel();
            this.lTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDiario = new System.Windows.Forms.TabPage();
            this.ttotal = new System.Windows.Forms.TextBox();
            this.tItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bReportD = new System.Windows.Forms.Button();
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.dtpd = new System.Windows.Forms.DateTimePicker();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbClose = new System.Windows.Forms.RadioButton();
            this.rbCancel = new System.Windows.Forms.RadioButton();
            this.rbini = new System.Windows.Forms.RadioButton();
            this.dgvdaily = new System.Windows.Forms.DataGridView();
            this.tpProduc = new System.Windows.Forms.TabPage();
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.cProd = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpProdD = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpProdH = new System.Windows.Forms.DateTimePicker();
            this.bFilterProd = new System.Windows.Forms.Button();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.pTop.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpDiario.SuspendLayout();
            this.gbDate.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdaily)).BeginInit();
            this.tpProduc.SuspendLayout();
            this.GB1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pTop.Controls.Add(this.lTitle);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(700, 29);
            this.pTop.TabIndex = 1;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(234, 3);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(163, 24);
            this.lTitle.TabIndex = 5;
            this.lTitle.Text = "R E P O R T E S";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDiario);
            this.tabControl1.Controls.Add(this.tpProduc);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 401);
            this.tabControl1.TabIndex = 2;
            // 
            // tpDiario
            // 
            this.tpDiario.Controls.Add(this.ttotal);
            this.tpDiario.Controls.Add(this.tItem);
            this.tpDiario.Controls.Add(this.label2);
            this.tpDiario.Controls.Add(this.label1);
            this.tpDiario.Controls.Add(this.bReportD);
            this.tpDiario.Controls.Add(this.gbDate);
            this.tpDiario.Controls.Add(this.gbStatus);
            this.tpDiario.Controls.Add(this.dgvdaily);
            this.tpDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDiario.Location = new System.Drawing.Point(4, 22);
            this.tpDiario.Name = "tpDiario";
            this.tpDiario.Padding = new System.Windows.Forms.Padding(3);
            this.tpDiario.Size = new System.Drawing.Size(692, 375);
            this.tpDiario.TabIndex = 0;
            this.tpDiario.Text = "Reporte Diario";
            this.tpDiario.UseVisualStyleBackColor = true;
            // 
            // ttotal
            // 
            this.ttotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ttotal.Enabled = false;
            this.ttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttotal.Location = new System.Drawing.Point(423, 83);
            this.ttotal.Name = "ttotal";
            this.ttotal.Size = new System.Drawing.Size(131, 22);
            this.ttotal.TabIndex = 19;
            // 
            // tItem
            // 
            this.tItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tItem.Enabled = false;
            this.tItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tItem.Location = new System.Drawing.Point(161, 83);
            this.tItem.Name = "tItem";
            this.tItem.Size = new System.Drawing.Size(131, 22);
            this.tItem.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Monto Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total de Productos:";
            // 
            // bReportD
            // 
            this.bReportD.BackgroundImage = global::Bar_Store.Presentacion.Properties.Resources.filter;
            this.bReportD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bReportD.Location = new System.Drawing.Point(580, 15);
            this.bReportD.Name = "bReportD";
            this.bReportD.Size = new System.Drawing.Size(55, 54);
            this.bReportD.TabIndex = 15;
            this.bReportD.UseVisualStyleBackColor = true;
            this.bReportD.Click += new System.EventHandler(this.bReportD_Click);
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.dtpd);
            this.gbDate.Location = new System.Drawing.Point(8, 15);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(246, 54);
            this.gbDate.TabIndex = 14;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "Fecha";
            // 
            // dtpd
            // 
            this.dtpd.Location = new System.Drawing.Point(6, 20);
            this.dtpd.Name = "dtpd";
            this.dtpd.Size = new System.Drawing.Size(234, 21);
            this.dtpd.TabIndex = 13;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbClose);
            this.gbStatus.Controls.Add(this.rbCancel);
            this.gbStatus.Controls.Add(this.rbini);
            this.gbStatus.Location = new System.Drawing.Point(260, 15);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(299, 54);
            this.gbStatus.TabIndex = 12;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Estatus";
            // 
            // rbClose
            // 
            this.rbClose.AutoSize = true;
            this.rbClose.Location = new System.Drawing.Point(107, 23);
            this.rbClose.Name = "rbClose";
            this.rbClose.Size = new System.Drawing.Size(85, 19);
            this.rbClose.TabIndex = 2;
            this.rbClose.TabStop = true;
            this.rbClose.Text = "Terminada";
            this.rbClose.UseVisualStyleBackColor = true;
            // 
            // rbCancel
            // 
            this.rbCancel.AutoSize = true;
            this.rbCancel.Location = new System.Drawing.Point(198, 23);
            this.rbCancel.Name = "rbCancel";
            this.rbCancel.Size = new System.Drawing.Size(84, 19);
            this.rbCancel.TabIndex = 1;
            this.rbCancel.TabStop = true;
            this.rbCancel.Text = "Cancelada";
            this.rbCancel.UseVisualStyleBackColor = true;
            // 
            // rbini
            // 
            this.rbini.AutoSize = true;
            this.rbini.Location = new System.Drawing.Point(9, 23);
            this.rbini.Name = "rbini";
            this.rbini.Size = new System.Drawing.Size(92, 19);
            this.rbini.TabIndex = 0;
            this.rbini.TabStop = true;
            this.rbini.Text = "En progreso";
            this.rbini.UseVisualStyleBackColor = true;
            // 
            // dgvdaily
            // 
            this.dgvdaily.AllowUserToAddRows = false;
            this.dgvdaily.AllowUserToDeleteRows = false;
            this.dgvdaily.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvdaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdaily.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdaily.Location = new System.Drawing.Point(3, 114);
            this.dgvdaily.Name = "dgvdaily";
            this.dgvdaily.ReadOnly = true;
            this.dgvdaily.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdaily.Size = new System.Drawing.Size(686, 258);
            this.dgvdaily.TabIndex = 11;
            // 
            // tpProduc
            // 
            this.tpProduc.Controls.Add(this.dgvProd);
            this.tpProduc.Controls.Add(this.panel1);
            this.tpProduc.Location = new System.Drawing.Point(4, 22);
            this.tpProduc.Name = "tpProduc";
            this.tpProduc.Padding = new System.Windows.Forms.Padding(3);
            this.tpProduc.Size = new System.Drawing.Size(692, 375);
            this.tpProduc.TabIndex = 1;
            this.tpProduc.Text = "Reporte por Producto";
            this.tpProduc.UseVisualStyleBackColor = true;
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.cProd);
            this.GB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB1.Location = new System.Drawing.Point(329, 18);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(237, 50);
            this.GB1.TabIndex = 6;
            this.GB1.TabStop = false;
            this.GB1.Text = "Selecciona un producto";
            // 
            // cProd
            // 
            this.cProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cProd.FormattingEnabled = true;
            this.cProd.Location = new System.Drawing.Point(6, 20);
            this.cProd.Name = "cProd";
            this.cProd.Size = new System.Drawing.Size(211, 23);
            this.cProd.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpProdH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpProdD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 81);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fechas ";
            // 
            // dtpProdD
            // 
            this.dtpProdD.Location = new System.Drawing.Point(53, 20);
            this.dtpProdD.Name = "dtpProdD";
            this.dtpProdD.Size = new System.Drawing.Size(234, 20);
            this.dtpProdD.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bFilterProd);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.GB1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 81);
            this.panel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Desde: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hasta:";
            // 
            // dtpProdH
            // 
            this.dtpProdH.Location = new System.Drawing.Point(53, 48);
            this.dtpProdH.Name = "dtpProdH";
            this.dtpProdH.Size = new System.Drawing.Size(234, 20);
            this.dtpProdH.TabIndex = 15;
            // 
            // bFilterProd
            // 
            this.bFilterProd.BackgroundImage = global::Bar_Store.Presentacion.Properties.Resources.filter;
            this.bFilterProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bFilterProd.Location = new System.Drawing.Point(592, 18);
            this.bFilterProd.Name = "bFilterProd";
            this.bFilterProd.Size = new System.Drawing.Size(55, 54);
            this.bFilterProd.TabIndex = 16;
            this.bFilterProd.UseVisualStyleBackColor = true;
            this.bFilterProd.Click += new System.EventHandler(this.bFilterProd_Click);
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProd.Location = new System.Drawing.Point(3, 103);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProd.Size = new System.Drawing.Size(686, 269);
            this.dgvProd.TabIndex = 17;
            // 
            // fRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 430);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fRep";
            this.Text = "fRep";
            this.Load += new System.EventHandler(this.fRep_Load);
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpDiario.ResumeLayout(false);
            this.tpDiario.PerformLayout();
            this.gbDate.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdaily)).EndInit();
            this.tpProduc.ResumeLayout(false);
            this.GB1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDiario;
        private System.Windows.Forms.DataGridView dgvdaily;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.DateTimePicker dtpd;
        private System.Windows.Forms.RadioButton rbClose;
        private System.Windows.Forms.RadioButton rbCancel;
        private System.Windows.Forms.RadioButton rbini;
        private System.Windows.Forms.Button bReportD;
        private System.Windows.Forms.TextBox tItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttotal;
        private System.Windows.Forms.TabPage tpProduc;
        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.ComboBox cProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpProdH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpProdD;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.Button bFilterProd;
    }
}