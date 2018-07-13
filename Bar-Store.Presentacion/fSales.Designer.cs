﻿namespace Bar_Store.Presentacion
{
    partial class fSales
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
            this.components = new System.ComponentModel.Container();
            this.lTitle = new System.Windows.Forms.Label();
            this.gbTables = new System.Windows.Forms.GroupBox();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.tDesc = new System.Windows.Forms.TextBox();
            this.lDesc = new System.Windows.Forms.Label();
            this.tId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProd = new System.Windows.Forms.GroupBox();
            this.tFilter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.pTop = new System.Windows.Forms.Panel();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.dgvCon = new System.Windows.Forms.DataGridView();
            this.pDataTop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tItems = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bEnd = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.gbCant = new System.Windows.Forms.GroupBox();
            this.tCant = new System.Windows.Forms.TextBox();
            this.contMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quitarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gbTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.gbProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.pTop.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).BeginInit();
            this.pDataTop.SuspendLayout();
            this.gbCant.SuspendLayout();
            this.contMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(199, 4);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(270, 24);
            this.lTitle.TabIndex = 5;
            this.lTitle.Text = "V E N T A S   A C T I V A S ";
            // 
            // gbTables
            // 
            this.gbTables.Controls.Add(this.bSave);
            this.gbTables.Controls.Add(this.bNew);
            this.gbTables.Controls.Add(this.dgvSales);
            this.gbTables.Controls.Add(this.tDesc);
            this.gbTables.Controls.Add(this.lDesc);
            this.gbTables.Controls.Add(this.tId);
            this.gbTables.Controls.Add(this.label1);
            this.gbTables.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbTables.Location = new System.Drawing.Point(0, 29);
            this.gbTables.Name = "gbTables";
            this.gbTables.Size = new System.Drawing.Size(235, 401);
            this.gbTables.TabIndex = 1;
            this.gbTables.TabStop = false;
            this.gbTables.Text = "M E S A S";
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSales.Location = new System.Drawing.Point(3, 137);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(229, 261);
            this.dgvSales.TabIndex = 8;
            this.dgvSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSales_CellClick);
            // 
            // tDesc
            // 
            this.tDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tDesc.Location = new System.Drawing.Point(11, 56);
            this.tDesc.Multiline = true;
            this.tDesc.Name = "tDesc";
            this.tDesc.Size = new System.Drawing.Size(218, 60);
            this.tDesc.TabIndex = 5;
            this.tDesc.TextChanged += new System.EventHandler(this.tDesc_TextChanged);
            // 
            // lDesc
            // 
            this.lDesc.AutoSize = true;
            this.lDesc.Location = new System.Drawing.Point(8, 40);
            this.lDesc.Name = "lDesc";
            this.lDesc.Size = new System.Drawing.Size(66, 13);
            this.lDesc.TabIndex = 4;
            this.lDesc.Text = "Descripcion:";
            // 
            // tId
            // 
            this.tId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tId.Location = new System.Drawing.Point(33, 17);
            this.tId.Name = "tId";
            this.tId.Size = new System.Drawing.Size(53, 20);
            this.tId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id:";
            // 
            // gbProd
            // 
            this.gbProd.Controls.Add(this.gbCant);
            this.gbProd.Controls.Add(this.bAdd);
            this.gbProd.Controls.Add(this.tFilter);
            this.gbProd.Controls.Add(this.label5);
            this.gbProd.Controls.Add(this.dgvProd);
            this.gbProd.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbProd.Location = new System.Drawing.Point(235, 29);
            this.gbProd.Name = "gbProd";
            this.gbProd.Size = new System.Drawing.Size(212, 401);
            this.gbProd.TabIndex = 2;
            this.gbProd.TabStop = false;
            this.gbProd.Text = "L I S T A  D E  P R O D U C T O S";
            // 
            // tFilter
            // 
            this.tFilter.BackColor = System.Drawing.Color.White;
            this.tFilter.Location = new System.Drawing.Point(9, 102);
            this.tFilter.Name = "tFilter";
            this.tFilter.Size = new System.Drawing.Size(172, 20);
            this.tFilter.TabIndex = 10;
            this.tFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tFilter_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Filtrar productos por nombre";
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProd.Location = new System.Drawing.Point(3, 137);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProd.Size = new System.Drawing.Size(206, 261);
            this.dgvProd.TabIndex = 9;
            this.dgvProd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellClick);
            this.dgvProd.Click += new System.EventHandler(this.dgvProd_Click);
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pTop.Controls.Add(this.lTitle);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(700, 29);
            this.pTop.TabIndex = 0;
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.dgvCon);
            this.gbData.Controls.Add(this.pDataTop);
            this.gbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbData.Location = new System.Drawing.Point(447, 29);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(253, 401);
            this.gbData.TabIndex = 3;
            this.gbData.TabStop = false;
            this.gbData.Text = "D A T O S    D E    C O N S U M O";
            // 
            // dgvCon
            // 
            this.dgvCon.AllowUserToAddRows = false;
            this.dgvCon.AllowUserToDeleteRows = false;
            this.dgvCon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCon.Location = new System.Drawing.Point(3, 137);
            this.dgvCon.Name = "dgvCon";
            this.dgvCon.ReadOnly = true;
            this.dgvCon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCon.Size = new System.Drawing.Size(247, 261);
            this.dgvCon.TabIndex = 10;
            this.dgvCon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCon_CellClick);
            // 
            // pDataTop
            // 
            this.pDataTop.Controls.Add(this.bEnd);
            this.pDataTop.Controls.Add(this.bClose);
            this.pDataTop.Controls.Add(this.label4);
            this.pDataTop.Controls.Add(this.tTotal);
            this.pDataTop.Controls.Add(this.label3);
            this.pDataTop.Controls.Add(this.tItems);
            this.pDataTop.Controls.Add(this.label2);
            this.pDataTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDataTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pDataTop.Location = new System.Drawing.Point(3, 16);
            this.pDataTop.Name = "pDataTop";
            this.pDataTop.Size = new System.Drawing.Size(247, 121);
            this.pDataTop.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "C O N S U M O S:";
            // 
            // tTotal
            // 
            this.tTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tTotal.Enabled = false;
            this.tTotal.Location = new System.Drawing.Point(8, 66);
            this.tTotal.Name = "tTotal";
            this.tTotal.Size = new System.Drawing.Size(100, 21);
            this.tTotal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total:";
            // 
            // tItems
            // 
            this.tItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tItems.Enabled = false;
            this.tItems.Location = new System.Drawing.Point(8, 24);
            this.tItems.Name = "tItems";
            this.tItems.Size = new System.Drawing.Size(100, 21);
            this.tItems.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Items:";
            // 
            // bEnd
            // 
            this.bEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnd.Image = global::Bar_Store.Presentacion.Properties.Resources.cancel1;
            this.bEnd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bEnd.Location = new System.Drawing.Point(183, 21);
            this.bEnd.Name = "bEnd";
            this.bEnd.Size = new System.Drawing.Size(61, 65);
            this.bEnd.TabIndex = 12;
            this.bEnd.Text = "Cancelar";
            this.bEnd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bEnd.UseVisualStyleBackColor = true;
            this.bEnd.Click += new System.EventHandler(this.bEnd_Click);
            // 
            // bClose
            // 
            this.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Image = global::Bar_Store.Presentacion.Properties.Resources.accept2;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bClose.Location = new System.Drawing.Point(115, 20);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(56, 66);
            this.bClose.TabIndex = 11;
            this.bClose.Text = "Terminar";
            this.bClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAdd.Image = global::Bar_Store.Presentacion.Properties.Resources.add11;
            this.bAdd.Location = new System.Drawing.Point(145, 15);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(61, 65);
            this.bAdd.TabIndex = 11;
            this.bAdd.Text = "Agregar";
            this.bAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bSave
            // 
            this.bSave.BackgroundImage = global::Bar_Store.Presentacion.Properties.Resources.save;
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSave.Location = new System.Drawing.Point(180, 10);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(44, 36);
            this.bSave.TabIndex = 10;
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bNew
            // 
            this.bNew.BackgroundImage = global::Bar_Store.Presentacion.Properties.Resources.script;
            this.bNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNew.Location = new System.Drawing.Point(97, 11);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(44, 36);
            this.bNew.TabIndex = 9;
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // gbCant
            // 
            this.gbCant.Controls.Add(this.tCant);
            this.gbCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCant.Location = new System.Drawing.Point(9, 16);
            this.gbCant.Name = "gbCant";
            this.gbCant.Size = new System.Drawing.Size(130, 64);
            this.gbCant.TabIndex = 12;
            this.gbCant.TabStop = false;
            this.gbCant.Text = "Cantidad";
            // 
            // tCant
            // 
            this.tCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tCant.Location = new System.Drawing.Point(6, 28);
            this.tCant.Name = "tCant";
            this.tCant.Size = new System.Drawing.Size(99, 21);
            this.tCant.TabIndex = 7;
            // 
            // contMenu
            // 
            this.contMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitarMenu});
            this.contMenu.Name = "contMenu";
            this.contMenu.Size = new System.Drawing.Size(169, 26);
            // 
            // quitarMenu
            // 
            this.quitarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.quitarMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitarMenu.Image = global::Bar_Store.Presentacion.Properties.Resources.cancel;
            this.quitarMenu.Name = "quitarMenu";
            this.quitarMenu.Size = new System.Drawing.Size(180, 22);
            this.quitarMenu.Text = "Quitar Producto";
            this.quitarMenu.Click += new System.EventHandler(this.quitarMenu_Click);
            // 
            // fSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 430);
            this.ContextMenuStrip = this.contMenu;
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbProd);
            this.Controls.Add(this.gbTables);
            this.Controls.Add(this.pTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fSales";
            this.Text = "fSales";
            this.Load += new System.EventHandler(this.fSales_Load);
            this.gbTables.ResumeLayout(false);
            this.gbTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.gbProd.ResumeLayout(false);
            this.gbProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.gbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).EndInit();
            this.pDataTop.ResumeLayout(false);
            this.pDataTop.PerformLayout();
            this.gbCant.ResumeLayout(false);
            this.gbCant.PerformLayout();
            this.contMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.GroupBox gbTables;
        private System.Windows.Forms.GroupBox gbProd;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.Label lDesc;
        private System.Windows.Forms.TextBox tDesc;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvCon;
        private System.Windows.Forms.Panel pDataTop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bEnd;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.GroupBox gbCant;
        private System.Windows.Forms.TextBox tCant;
        private System.Windows.Forms.ContextMenuStrip contMenu;
        private System.Windows.Forms.ToolStripMenuItem quitarMenu;
    }
}