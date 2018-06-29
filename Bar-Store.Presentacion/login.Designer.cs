namespace Bar_Store.Presentacion
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tUser = new System.Windows.Forms.TextBox();
            this.tPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bAccept = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GB1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.bCancel);
            this.GB1.Controls.Add(this.bAccept);
            this.GB1.Controls.Add(this.tPass);
            this.GB1.Controls.Add(this.label2);
            this.GB1.Controls.Add(this.tUser);
            this.GB1.Controls.Add(this.label1);
            this.GB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB1.Location = new System.Drawing.Point(206, 4);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(244, 157);
            this.GB1.TabIndex = 1;
            this.GB1.TabStop = false;
            this.GB1.Text = "L O G I N ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // tUser
            // 
            this.tUser.Location = new System.Drawing.Point(96, 32);
            this.tUser.MaxLength = 20;
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(100, 21);
            this.tUser.TabIndex = 1;
            this.tUser.Text = "miguel";
            // 
            // tPass
            // 
            this.tPass.Location = new System.Drawing.Point(96, 67);
            this.tPass.MaxLength = 30;
            this.tPass.Name = "tPass";
            this.tPass.PasswordChar = '*';
            this.tPass.Size = new System.Drawing.Size(100, 21);
            this.tPass.TabIndex = 3;
            this.tPass.Text = "123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // bAccept
            // 
            this.bAccept.BackgroundImage = global::Bar_Store.Presentacion.Properties.Resources.accept;
            this.bAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bAccept.Location = new System.Drawing.Point(34, 105);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(58, 45);
            this.bAccept.TabIndex = 4;
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackgroundImage = global::Bar_Store.Presentacion.Properties.Resources.cancel;
            this.bCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(143, 105);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(53, 45);
            this.bCancel.TabIndex = 5;
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bar_Store.Presentacion.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AcceptButton = this.bAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(452, 163);
            this.ControlBox = false;
            this.Controls.Add(this.GB1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I N I C I O     D E    S E S I O N";
            this.Load += new System.EventHandler(this.login_Load);
            this.GB1.ResumeLayout(false);
            this.GB1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.TextBox tPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.Label label1;
    }
}