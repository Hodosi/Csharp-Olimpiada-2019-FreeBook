namespace AplicatieFreeBook
{
    partial class MeniuFreeBook
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Carti_disponibile = new System.Windows.Forms.TabPage();
            this.dataGridView_disponibil = new System.Windows.Forms.DataGridView();
            this.Imprumuta_carte = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage_Carti_imprumutate = new System.Windows.Forms.TabPage();
            this.tabPage_Statistici_Bibllioteca = new System.Windows.Forms.TabPage();
            this.label_email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label_disponibilitate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_Carti_disponibile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_disponibil)).BeginInit();
            this.tabPage_Carti_imprumutate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label_email);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 634);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Carti_disponibile);
            this.tabControl1.Controls.Add(this.tabPage_Carti_imprumutate);
            this.tabControl1.Controls.Add(this.tabPage_Statistici_Bibllioteca);
            this.tabControl1.Location = new System.Drawing.Point(12, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1056, 542);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage_Carti_disponibile
            // 
            this.tabPage_Carti_disponibile.Controls.Add(this.dataGridView_disponibil);
            this.tabPage_Carti_disponibile.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Carti_disponibile.Name = "tabPage_Carti_disponibile";
            this.tabPage_Carti_disponibile.Size = new System.Drawing.Size(1048, 500);
            this.tabPage_Carti_disponibile.TabIndex = 0;
            this.tabPage_Carti_disponibile.Text = "Carti disponibile";
            this.tabPage_Carti_disponibile.UseVisualStyleBackColor = true;
            // 
            // dataGridView_disponibil
            // 
            this.dataGridView_disponibil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_disponibil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_disponibil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imprumuta_carte});
            this.dataGridView_disponibil.Location = new System.Drawing.Point(14, 14);
            this.dataGridView_disponibil.Name = "dataGridView_disponibil";
            this.dataGridView_disponibil.RowHeadersWidth = 51;
            this.dataGridView_disponibil.RowTemplate.Height = 24;
            this.dataGridView_disponibil.Size = new System.Drawing.Size(1026, 481);
            this.dataGridView_disponibil.TabIndex = 0;
            this.dataGridView_disponibil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_disponibil_CellContentClick);
            // 
            // Imprumuta_carte
            // 
            this.Imprumuta_carte.HeaderText = "Imprumuta carte";
            this.Imprumuta_carte.MinimumWidth = 6;
            this.Imprumuta_carte.Name = "Imprumuta_carte";
            // 
            // tabPage_Carti_imprumutate
            // 
            this.tabPage_Carti_imprumutate.Controls.Add(this.label_disponibilitate);
            this.tabPage_Carti_imprumutate.Controls.Add(this.label2);
            this.tabPage_Carti_imprumutate.Controls.Add(this.progressBar1);
            this.tabPage_Carti_imprumutate.Controls.Add(this.dataGridView1);
            this.tabPage_Carti_imprumutate.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Carti_imprumutate.Name = "tabPage_Carti_imprumutate";
            this.tabPage_Carti_imprumutate.Size = new System.Drawing.Size(1048, 500);
            this.tabPage_Carti_imprumutate.TabIndex = 1;
            this.tabPage_Carti_imprumutate.Text = "Carti imprumutate";
            this.tabPage_Carti_imprumutate.UseVisualStyleBackColor = true;
            // 
            // tabPage_Statistici_Bibllioteca
            // 
            this.tabPage_Statistici_Bibllioteca.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Statistici_Bibllioteca.Name = "tabPage_Statistici_Bibllioteca";
            this.tabPage_Statistici_Bibllioteca.Size = new System.Drawing.Size(1048, 500);
            this.tabPage_Statistici_Bibllioteca.TabIndex = 2;
            this.tabPage_Statistici_Bibllioteca.Text = "Statistici Bibllioteca";
            this.tabPage_Statistici_Bibllioteca.UseVisualStyleBackColor = true;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(512, 22);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(29, 29);
            this.label_email.TabIndex = 1;
            this.label_email.Text = "\"\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email utilizator:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 381);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(393, 455);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(581, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Disponibilitate:";
            // 
            // label_disponibilitate
            // 
            this.label_disponibilitate.AutoSize = true;
            this.label_disponibilitate.Location = new System.Drawing.Point(254, 455);
            this.label_disponibilitate.Name = "label_disponibilitate";
            this.label_disponibilitate.Size = new System.Drawing.Size(29, 29);
            this.label_disponibilitate.TabIndex = 3;
            this.label_disponibilitate.Text = "\"\"";
            // 
            // MeniuFreeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 634);
            this.Controls.Add(this.panel1);
            this.Name = "MeniuFreeBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuFreeBook";
            this.Load += new System.EventHandler(this.MeniuFreeBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Carti_disponibile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_disponibil)).EndInit();
            this.tabPage_Carti_imprumutate.ResumeLayout(false);
            this.tabPage_Carti_imprumutate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Carti_disponibile;
        private System.Windows.Forms.DataGridView dataGridView_disponibil;
        private System.Windows.Forms.DataGridViewButtonColumn Imprumuta_carte;
        private System.Windows.Forms.TabPage tabPage_Carti_imprumutate;
        private System.Windows.Forms.TabPage tabPage_Statistici_Bibllioteca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_disponibilitate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}