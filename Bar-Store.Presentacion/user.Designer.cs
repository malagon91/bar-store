namespace Bar_Store.Presentacion
{
    partial class user
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tLogin = new System.Windows.Forms.TextBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.luser = new System.Windows.Forms.Label();
            this.tPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cAdmin = new System.Windows.Forms.CheckBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.GB1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(121, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(378, 24);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "C A T A L A G O   D E   U S U A R I O S";
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.bDelete);
            this.GB1.Controls.Add(this.bNew);
            this.GB1.Controls.Add(this.bSave);
            this.GB1.Controls.Add(this.cAdmin);
            this.GB1.Controls.Add(this.label3);
            this.GB1.Controls.Add(this.tPass);
            this.GB1.Controls.Add(this.label2);
            this.GB1.Controls.Add(this.tName);
            this.GB1.Controls.Add(this.luser);
            this.GB1.Controls.Add(this.tLogin);
            this.GB1.Controls.Add(this.label1);
            this.GB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB1.Location = new System.Drawing.Point(93, 46);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(478, 135);
            this.GB1.TabIndex = 1;
            this.GB1.TabStop = false;
            this.GB1.Text = "Informacion de usuarios";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(93, 187);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(478, 192);
            this.dgv.TabIndex = 2;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // tLogin
            // 
            this.tLogin.Location = new System.Drawing.Point(103, 28);
            this.tLogin.MaxLength = 20;
            this.tLogin.Name = "tLogin";
            this.tLogin.Size = new System.Drawing.Size(281, 21);
            this.tLogin.TabIndex = 1;
            this.tLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tLogin_KeyPress);
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(103, 56);
            this.tName.MaxLength = 30;
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(281, 21);
            this.tName.TabIndex = 3;
            this.tName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tName_KeyPress);
            // 
            // luser
            // 
            this.luser.AutoSize = true;
            this.luser.Location = new System.Drawing.Point(6, 59);
            this.luser.Name = "luser";
            this.luser.Size = new System.Drawing.Size(55, 15);
            this.luser.TabIndex = 2;
            this.luser.Text = "Nombre:";
            // 
            // tPass
            // 
            this.tPass.Location = new System.Drawing.Point(103, 84);
            this.tPass.MaxLength = 30;
            this.tPass.Name = "tPass";
            this.tPass.PasswordChar = '*';
            this.tPass.Size = new System.Drawing.Size(281, 21);
            this.tPass.TabIndex = 5;
            this.tPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tPass_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Es Admin:";
            // 
            // cAdmin
            // 
            this.cAdmin.AutoSize = true;
            this.cAdmin.Location = new System.Drawing.Point(103, 111);
            this.cAdmin.Name = "cAdmin";
            this.cAdmin.Size = new System.Drawing.Size(102, 19);
            this.cAdmin.TabIndex = 7;
            this.cAdmin.Text = "Administrador";
            this.cAdmin.UseVisualStyleBackColor = true;
            this.cAdmin.CheckedChanged += new System.EventHandler(this.cAdmin_CheckedChanged);
            this.cAdmin.Click += new System.EventHandler(this.cAdmin_Click);
            // 
            // bSave
            // 
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSave.Location = new System.Drawing.Point(390, 56);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(68, 31);
            this.bSave.TabIndex = 9;
            this.bSave.Text = "Guardar";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bNew
            // 
            this.bNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNew.Location = new System.Drawing.Point(390, 23);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(68, 31);
            this.bNew.TabIndex = 10;
            this.bNew.Text = "Nuevo ";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bDelete.Location = new System.Drawing.Point(390, 88);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(68, 31);
            this.bDelete.TabIndex = 11;
            this.bDelete.Text = "Eliminar";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 391);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.GB1);
            this.Controls.Add(this.lTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "user";
            this.Text = " U S U A R I O S";
            this.Load += new System.EventHandler(this.user_Load);
            this.GB1.ResumeLayout(false);
            this.GB1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label luser;
        private System.Windows.Forms.TextBox tLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cAdmin;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bSave;
    }
}