namespace Bar_Store.Presentacion
{
    partial class fInventory
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
            this.lTitle = new System.Windows.Forms.Label();
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cProd = new System.Windows.Forms.ComboBox();
            this.tCant = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bSave = new System.Windows.Forms.Button();
            this.lnote = new System.Windows.Forms.Label();
            this.GB1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(144, 7);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(363, 24);
            this.lTitle.TabIndex = 4;
            this.lTitle.Text = "A G R E G A R     P R O D U C T O S  ";
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.cProd);
            this.GB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB1.Location = new System.Drawing.Point(91, 34);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(256, 48);
            this.GB1.TabIndex = 5;
            this.GB1.TabStop = false;
            this.GB1.Text = "Selecciona un producto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tCant);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(353, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(74, 48);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad";
            // 
            // cProd
            // 
            this.cProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cProd.FormattingEnabled = true;
            this.cProd.Location = new System.Drawing.Point(6, 19);
            this.cProd.Name = "cProd";
            this.cProd.Size = new System.Drawing.Size(233, 23);
            this.cProd.TabIndex = 0;
            this.cProd.SelectedIndexChanged += new System.EventHandler(this.cProd_SelectedIndexChanged);
            // 
            // tCant
            // 
            this.tCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tCant.Location = new System.Drawing.Point(6, 19);
            this.tCant.Name = "tCant";
            this.tCant.Size = new System.Drawing.Size(53, 21);
            this.tCant.TabIndex = 0;
            this.tCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tCant_KeyPress);
            this.tCant.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tCant_KeyUp);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(45, 88);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(560, 316);
            this.dgv.TabIndex = 7;
            // 
            // bSave
            // 
            this.bSave.BackgroundImage = global::Bar_Store.Presentacion.Properties.Resources.save;
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSave.Location = new System.Drawing.Point(452, 34);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(55, 48);
            this.bSave.TabIndex = 8;
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // lnote
            // 
            this.lnote.AutoSize = true;
            this.lnote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnote.ForeColor = System.Drawing.Color.Red;
            this.lnote.Location = new System.Drawing.Point(88, 407);
            this.lnote.Name = "lnote";
            this.lnote.Size = new System.Drawing.Size(375, 16);
            this.lnote.TabIndex = 9;
            this.lnote.Text = "Si necesitas dismuir la cantidad coloca el numero en negativo";
            // 
            // fInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 430);
            this.Controls.Add(this.lnote);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GB1);
            this.Controls.Add(this.lTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fInventory";
            this.Text = "fInventory";
            this.Load += new System.EventHandler(this.fInventory_Load);
            this.GB1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.ComboBox cProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tCant;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lnote;
    }
}