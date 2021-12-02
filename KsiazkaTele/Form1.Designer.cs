
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
            this.podmien = new System.Windows.Forms.Button();
            this.TrybEdycji = new System.Windows.Forms.Button();
            this.TrybEdycjiLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.colourComboBox = new System.Windows.Forms.ComboBox();
            this.ColorButton = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Button();
            this.LStart = new System.Windows.Forms.TextBox();
            this.LKoncowa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TDelete = new System.Windows.Forms.Button();
            this.TUpdate = new System.Windows.Forms.Button();
            this.errorTestLabel = new System.Windows.Forms.Label();
            this.ClrFil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lp,
            this.Imie,
            this.Nazwisko,
            this.NrTel});
            this.dataGridView1.Location = new System.Drawing.Point(9, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(460, 420);
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
            this.Dodaj.Location = new System.Drawing.Point(564, 54);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 1;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // Usun
            // 
            this.Usun.Location = new System.Drawing.Point(645, 54);
            this.Usun.Name = "Usun";
            this.Usun.Size = new System.Drawing.Size(75, 23);
            this.Usun.TabIndex = 2;
            this.Usun.Text = "Usun";
            this.Usun.UseVisualStyleBackColor = true;
            this.Usun.Click += new System.EventHandler(this.Usun_Click);
            // 
            // LpText
            // 
            this.LpText.Location = new System.Drawing.Point(481, 28);
            this.LpText.Name = "LpText";
            this.LpText.Size = new System.Drawing.Size(75, 20);
            this.LpText.TabIndex = 3;
            // 
            // ImieText
            // 
            this.ImieText.Location = new System.Drawing.Point(564, 28);
            this.ImieText.Name = "ImieText";
            this.ImieText.Size = new System.Drawing.Size(75, 20);
            this.ImieText.TabIndex = 4;
            this.ImieText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // NazwiskoText
            // 
            this.NazwiskoText.Location = new System.Drawing.Point(645, 28);
            this.NazwiskoText.Name = "NazwiskoText";
            this.NazwiskoText.Size = new System.Drawing.Size(75, 20);
            this.NazwiskoText.TabIndex = 5;
            // 
            // NrTelText
            // 
            this.NrTelText.Location = new System.Drawing.Point(726, 28);
            this.NrTelText.Name = "NrTelText";
            this.NrTelText.Size = new System.Drawing.Size(75, 20);
            this.NrTelText.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(723, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "NrTel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lp";
            // 
            // podmien
            // 
            this.podmien.Location = new System.Drawing.Point(564, 54);
            this.podmien.Name = "podmien";
            this.podmien.Size = new System.Drawing.Size(75, 23);
            this.podmien.TabIndex = 14;
            this.podmien.Text = "Podmien";
            this.podmien.UseVisualStyleBackColor = true;
            this.podmien.Click += new System.EventHandler(this.podmien_Click);
            // 
            // TrybEdycji
            // 
            this.TrybEdycji.Location = new System.Drawing.Point(481, 54);
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
            this.TrybEdycjiLabel.Location = new System.Drawing.Point(481, 80);
            this.TrybEdycjiLabel.Name = "TrybEdycjiLabel";
            this.TrybEdycjiLabel.Size = new System.Drawing.Size(115, 13);
            this.TrybEdycjiLabel.TabIndex = 16;
            this.TrybEdycjiLabel.Text = "Tryb edycji: wyłączony";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(481, 103);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 18;
            // 
            // colourComboBox
            // 
            this.colourComboBox.FormattingEnabled = true;
            this.colourComboBox.Items.AddRange(new object[] {
            "Rodzina",
            "Przyjaciele",
            "Nie dzwonić",
            "Różowy"});
            this.colourComboBox.Location = new System.Drawing.Point(726, 56);
            this.colourComboBox.Name = "colourComboBox";
            this.colourComboBox.Size = new System.Drawing.Size(75, 21);
            this.colourComboBox.TabIndex = 19;
            this.colourComboBox.SelectedIndexChanged += new System.EventHandler(this.colourComboBox_SelectedIndexChanged);
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(726, 83);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(75, 23);
            this.ColorButton.TabIndex = 20;
            this.ColorButton.Text = "Ustaw kolor";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(481, 209);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(106, 23);
            this.Test.TabIndex = 21;
            this.Test.Text = "Test dodawania ";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // LStart
            // 
            this.LStart.Location = new System.Drawing.Point(481, 273);
            this.LStart.Name = "LStart";
            this.LStart.Size = new System.Drawing.Size(75, 20);
            this.LStart.TabIndex = 22;
            // 
            // LKoncowa
            // 
            this.LKoncowa.Location = new System.Drawing.Point(580, 273);
            this.LKoncowa.Name = "LKoncowa";
            this.LKoncowa.Size = new System.Drawing.Size(75, 20);
            this.LKoncowa.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Liczba Startowa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Liczba Końcowa";
            // 
            // TDelete
            // 
            this.TDelete.Location = new System.Drawing.Point(593, 209);
            this.TDelete.Name = "TDelete";
            this.TDelete.Size = new System.Drawing.Size(91, 23);
            this.TDelete.TabIndex = 27;
            this.TDelete.Text = "Test usówania";
            this.TDelete.UseVisualStyleBackColor = true;
            this.TDelete.Click += new System.EventHandler(this.TDelete_Click);
            // 
            // TUpdate
            // 
            this.TUpdate.Location = new System.Drawing.Point(695, 209);
            this.TUpdate.Name = "TUpdate";
            this.TUpdate.Size = new System.Drawing.Size(106, 23);
            this.TUpdate.TabIndex = 28;
            this.TUpdate.Text = "Test podmiany";
            this.TUpdate.UseVisualStyleBackColor = true;
            this.TUpdate.Click += new System.EventHandler(this.TUpdate_Click);
            // 
            // errorTestLabel
            // 
            this.errorTestLabel.AutoSize = true;
            this.errorTestLabel.Location = new System.Drawing.Point(481, 327);
            this.errorTestLabel.Name = "errorTestLabel";
            this.errorTestLabel.Size = new System.Drawing.Size(16, 13);
            this.errorTestLabel.TabIndex = 29;
            this.errorTestLabel.Text = "0 ";
            // 
            // ClrFil
            // 
            this.ClrFil.Location = new System.Drawing.Point(694, 270);
            this.ClrFil.Name = "ClrFil";
            this.ClrFil.Size = new System.Drawing.Size(106, 23);
            this.ClrFil.TabIndex = 30;
            this.ClrFil.Text = "Wyczysc plik";
            this.ClrFil.UseVisualStyleBackColor = true;
            this.ClrFil.Click += new System.EventHandler(this.ClrFil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.ClrFil);
            this.Controls.Add(this.errorTestLabel);
            this.Controls.Add(this.TUpdate);
            this.Controls.Add(this.TDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LKoncowa);
            this.Controls.Add(this.LStart);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.colourComboBox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.TrybEdycjiLabel);
            this.Controls.Add(this.TrybEdycji);
            this.Controls.Add(this.podmien);
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
        private System.Windows.Forms.Button podmien;
        private System.Windows.Forms.Button TrybEdycji;
        private System.Windows.Forms.Label TrybEdycjiLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.ComboBox colourComboBox;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.TextBox LStart;
        private System.Windows.Forms.TextBox LKoncowa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button TDelete;
        private System.Windows.Forms.Button TUpdate;
        private System.Windows.Forms.Label errorTestLabel;
        private System.Windows.Forms.Button ClrFil;
    }
}

