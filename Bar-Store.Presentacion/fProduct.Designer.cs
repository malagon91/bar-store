namespace Bar_Store.Presentacion
{
    partial class fProduct
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.tDesc = new System.Windows.Forms.TextBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.luser = new System.Windows.Forms.Label();
            this.tID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.GB1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(31, 187);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(600, 192);
            this.dgv.TabIndex = 5;
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.tDesc);
            this.GB1.Controls.Add(this.bDelete);
            this.GB1.Controls.Add(this.bNew);
            this.GB1.Controls.Add(this.bSave);
            this.GB1.Controls.Add(this.label3);
            this.GB1.Controls.Add(this.tCost);
            this.GB1.Controls.Add(this.label2);
            this.GB1.Controls.Add(this.tName);
            this.GB1.Controls.Add(this.luser);
            this.GB1.Controls.Add(this.tID);
            this.GB1.Controls.Add(this.label1);
            this.GB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB1.Location = new System.Drawing.Point(95, 37);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(478, 144);
            this.GB1.TabIndex = 4;
            this.GB1.TabStop = false;
            this.GB1.Text = "Informacion de productos";
            // 
            // tDesc
            // 
            this.tDesc.Location = new System.Drawing.Point(103, 111);
            this.tDesc.MaxLength = 30;
            this.tDesc.Name = "tDesc";
            this.tDesc.Size = new System.Drawing.Size(281, 21);
            this.tDesc.TabIndex = 4;
            this.tDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tDesc_KeyPress);
            // 
            // bDelete
            // 
            this.bDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bDelete.Location = new System.Drawing.Point(390, 94);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(68, 31);
            this.bDelete.TabIndex = 7;
            this.bDelete.Text = "Eliminar";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bNew
            // 
            this.bNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNew.Location = new System.Drawing.Point(390, 29);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(68, 31);
            this.bNew.TabIndex = 5;
            this.bNew.Text = "Nuevo ";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bSave
            // 
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSave.Location = new System.Drawing.Point(390, 62);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(68, 31);
            this.bSave.TabIndex = 6;
            this.bSave.Text = "Guardar";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descripcion";
            // 
            // tCost
            // 
            this.tCost.Location = new System.Drawing.Point(103, 84);
            this.tCost.MaxLength = 30;
            this.tCost.Name = "tCost";
            this.tCost.Size = new System.Drawing.Size(281, 21);
            this.tCost.TabIndex = 3;
            this.tCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tCost_KeyPress);
            this.tCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tCost_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Costo/Unidad:";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(103, 56);
            this.tName.MaxLength = 30;
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(281, 21);
            this.tName.TabIndex = 2;
            this.tName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tName_KeyPress);
            // 
            // luser
            // 
            this.luser.AutoSize = true;
            this.luser.Location = new System.Drawing.Point(6, 59);
            this.luser.Name = "luser";
            this.luser.Size = new System.Drawing.Size(55, 15);
            this.luser.TabIndex = 12;
            this.luser.Text = "Nombre:";
            // 
            // tID
            // 
            this.tID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tID.Enabled = false;
            this.tID.Location = new System.Drawing.Point(103, 29);
            this.tID.MaxLength = 20;
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(281, 21);
            this.tID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID:";
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(123, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(408, 24);
            this.lTitle.TabIndex = 3;
            this.lTitle.Text = "C A T A L A G O   D E   P R O D U C T O S";
            // 
            // fProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 430);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.GB1);
            this.Controls.Add(this.lTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fProduct";
            this.Text = "fProduct";
            this.Load += new System.EventHandler(this.fProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.GB1.ResumeLayout(false);
            this.GB1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label luser;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.TextBox tDesc;
    }
}