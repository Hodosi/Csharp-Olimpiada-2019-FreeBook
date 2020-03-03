namespace AplicatieFreeBook
{
    partial class LogareFreeBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Login = new System.Windows.Forms.Button();
            this.textBox_parola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Login);
            this.panel1.Controls.Add(this.textBox_parola);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_email);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 305);
            this.panel1.TabIndex = 0;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(230, 202);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(163, 49);
            this.button_Login.TabIndex = 4;
            this.button_Login.Text = "Logare";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // textBox_parola
            // 
            this.textBox_parola.Location = new System.Drawing.Point(151, 130);
            this.textBox_parola.Name = "textBox_parola";
            this.textBox_parola.PasswordChar = '*';
            this.textBox_parola.Size = new System.Drawing.Size(343, 34);
            this.textBox_parola.TabIndex = 3;
            this.textBox_parola.Text = "dana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(151, 70);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(343, 34);
            this.textBox_email.TabIndex = 1;
            this.textBox_email.Text = "dana@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // LogareFreeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 305);
            this.Controls.Add(this.panel1);
            this.Name = "LogareFreeBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogareFreeBook";
            this.Load += new System.EventHandler(this.LogareFreeBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.TextBox textBox_parola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label1;
    }
}