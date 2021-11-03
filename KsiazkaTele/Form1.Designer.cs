
namespace KsiazkaTele
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Lp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Usun = new System.Windows.Forms.Button();
            this.LpText = new System.Windows.Forms.TextBox();
            this.ImieText = new System.Windows.Forms.TextBox();
            this.NazwiskoText = new System.Windows.Forms.TextBox();
            this.NrTelText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.podmien = new System.Windows.Forms.Button();
            this.TrybEdycji = new System.Windows.Forms.Button();
            this.TrybEdycjiLabel = new System.Windows.Forms.Label();
            this.Load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lp,
            this.Imie,
            this.Nazwisko,
            this.NrTel});
            this.dataGridView1.Location = new System.Drawing.Point(9, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(463, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Lp
            // 
            this.Lp.HeaderText = "Lp";
            this.Lp.Name = "Lp";
            this.Lp.ReadOnly = true;
            // 
            // Imie
            // 
            this.Imie.HeaderText = "Imie";
            this.Imie.Name = "Imie";
            this.Imie.ReadOnly = true;
            // 
            // Nazwisko
            // 
            this.Nazwisko.HeaderText = "Nazwisko";
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.ReadOnly = true;
            // 
            // NrTel
            // 
            this.NrTel.HeaderText = "NrTel";
            this.NrTel.Name = "NrTel";
            this.NrTel.ReadOnly = true;
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(561, 56);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 1;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // Usun
            // 
            this.Usun.Location = new System.Drawing.Point(642, 56);
            this.Usun.Name = "Usun";
            this.Usun.Size = new System.Drawing.Size(75, 23);
            this.Usun.TabIndex = 2;
            this.Usun.Text = "Usun";
            this.Usun.UseVisualStyleBackColor = true;
            this.Usun.Click += new System.EventHandler(this.Usun_Click);
            // 
            // LpText
            // 
            this.LpText.Location = new System.Drawing.Point(478, 30);
            this.LpText.Name = "LpText";
            this.LpText.Size = new System.Drawing.Size(75, 20);
            this.LpText.TabIndex = 3;
            // 
            // ImieText
            // 
            this.ImieText.Location = new System.Drawing.Point(561, 30);
            this.ImieText.Name = "ImieText";
            this.ImieText.Size = new System.Drawing.Size(75, 20);
            this.ImieText.TabIndex = 4;
            this.ImieText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // NazwiskoText
            // 
            this.NazwiskoText.Location = new System.Drawing.Point(642, 30);
            this.NazwiskoText.Name = "NazwiskoText";
            this.NazwiskoText.Size = new System.Drawing.Size(75, 20);
            this.NazwiskoText.TabIndex = 5;
            // 
            // NrTelText
            // 
            this.NrTelText.Location = new System.Drawing.Point(723, 30);
            this.NrTelText.Name = "NrTelText";
            this.NrTelText.Size = new System.Drawing.Size(75, 20);
            this.NrTelText.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(720, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "NrTel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lp";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(487, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // podmien
            // 
            this.podmien.Location = new System.Drawing.Point(561, 56);
            this.podmien.Name = "podmien";
            this.podmien.Size = new System.Drawing.Size(75, 23);
            this.podmien.TabIndex = 14;
            this.podmien.Text = "Podmien";
            this.podmien.UseVisualStyleBackColor = true;
            this.podmien.Click += new System.EventHandler(this.podmien_Click);
            // 
            // TrybEdycji
            // 
            this.TrybEdycji.Location = new System.Drawing.Point(478, 56);
            this.TrybEdycji.Name = "TrybEdycji";
            this.TrybEdycji.Size = new System.Drawing.Size(75, 23);
            this.TrybEdycji.TabIndex = 15;
            this.TrybEdycji.Text = "Tryb edycji";
            this.TrybEdycji.UseVisualStyleBackColor = true;
            this.TrybEdycji.Click += new System.EventHandler(this.TrybEdycji_Click);
            // 
            // TrybEdycjiLabel
            // 
            this.TrybEdycjiLabel.AutoSize = true;
            this.TrybEdycjiLabel.Location = new System.Drawing.Point(478, 82);
            this.TrybEdycjiLabel.Name = "TrybEdycjiLabel";
            this.TrybEdycjiLabel.Size = new System.Drawing.Size(115, 13);
            this.TrybEdycjiLabel.TabIndex = 16;
            this.TrybEdycjiLabel.Text = "Tryb edycji: wyłączony";
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(568, 197);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 17;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.TrybEdycjiLabel);
            this.Controls.Add(this.TrybEdycji);
            this.Controls.Add(this.podmien);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NrTelText);
            this.Controls.Add(this.NazwiskoText);
            this.Controls.Add(this.ImieText);
            this.Controls.Add(this.LpText);
            this.Controls.Add(this.Usun);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrTel;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button Usun;
        private System.Windows.Forms.TextBox LpText;
        private System.Windows.Forms.TextBox ImieText;
        private System.Windows.Forms.TextBox NazwiskoText;
        private System.Windows.Forms.TextBox NrTelText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button podmien;
        private System.Windows.Forms.Button TrybEdycji;
        private System.Windows.Forms.Label TrybEdycjiLabel;
        private System.Windows.Forms.Button Load;
    }
}

