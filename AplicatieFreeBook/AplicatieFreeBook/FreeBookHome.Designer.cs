namespace AplicatieFreeBook
{
    partial class FreeBookHome
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_Descreiere = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.button_signin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_Descreiere
            // 
            this.textBox_Descreiere.Enabled = false;
            this.textBox_Descreiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Descreiere.Location = new System.Drawing.Point(0, 288);
            this.textBox_Descreiere.Multiline = true;
            this.textBox_Descreiere.Name = "textBox_Descreiere";
            this.textBox_Descreiere.Size = new System.Drawing.Size(800, 91);
            this.textBox_Descreiere.TabIndex = 1;
            this.textBox_Descreiere.Text = "Aceasta este o descriere";
            this.textBox_Descreiere.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(12, 385);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(325, 53);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Logare";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_signin
            // 
            this.button_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signin.Location = new System.Drawing.Point(463, 385);
            this.button_signin.Name = "button_signin";
            this.button_signin.Size = new System.Drawing.Size(325, 53);
            this.button_signin.TabIndex = 3;
            this.button_signin.Text = "Inregistrare";
            this.button_signin.UseVisualStyleBackColor = true;
            this.button_signin.Click += new System.EventHandler(this.button_signin_Click);
            // 
            // FreeBookHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_signin);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_Descreiere);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FreeBookHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FreeBookHome";
            this.Load += new System.EventHandler(this.FreeBookHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_Descreiere;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_signin;
    }
}