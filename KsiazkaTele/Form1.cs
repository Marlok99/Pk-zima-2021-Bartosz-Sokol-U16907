using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KsiazkaTele
{
    public partial class Form1 : Form
    {

        // customizacaj np na lini 1 na zielono itp itd

        public Form1()
        {
            InitializeComponent();
            podmien.Visible = false;
            label4.Enabled = false;
            LpText.Enabled = false;
            Usun.Enabled = false;
            colourComboBox.Enabled = false;
            ColorButton.Enabled = false;
            KTkomponent Ksiazka = new KTkomponent();
            Ksiazka.LoadTextFile(null, null, dataGridView1);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void colourComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // dodaj
        private void button1_Click(object sender, EventArgs e)
        {
            KTkomponent Ksiazka = new KTkomponent();
            Data data = new Data(ImieText.Text, NazwiskoText.Text, NrTelText.Text);
            if (!Ksiazka.CheckIfexists(data))
            {
                Ksiazka.SetText("0", data, dataGridView1, ErrorLabel);
                Ksiazka.AddToTextFile(data, colourComboBox.SelectedIndex, ErrorLabel);
            }
            else
            {
                ErrorLabel.Text = "Taki numer telefonu juz istnieje";
            }


        }

        private void Usun_Click(object sender, EventArgs e)
        {
            KTkomponent Ksiazka = new KTkomponent();
            Ksiazka.RemoveAt(dataGridView1, LpText, ErrorLabel);
        }



        private bool przycisk = true;
        private void TrybEdycji_Click(object sender, EventArgs e)
        {

            przycisk = !przycisk;
            podmien.Visible = !przycisk;
            Dodaj.Visible = przycisk;
            label4.Enabled = !przycisk;
            LpText.Enabled = !przycisk;
            Usun.Enabled = !przycisk;
            colourComboBox.Enabled = !przycisk;
            ColorButton.Enabled = !przycisk;
            if (!przycisk)
            {
                TrybEdycjiLabel.Text = "Tryb edycji : Włączony";
            }
            else
            {
                TrybEdycjiLabel.Text = "Tryb edycji : Wyłączony";
            }
        }

        private void podmien_Click(object sender, EventArgs e)
        {
            KTkomponent Ksiazka = new KTkomponent();
            Data data = new Data(ImieText.Text, NazwiskoText.Text, NrTelText.Text);
            if (LpText.Text != "")
            {
                if (!Ksiazka.CheckIfexists(data))
                {
                    Ksiazka.RemoveAt(dataGridView1, LpText, null, data);
                }
                else
                {
                    ErrorLabel.Text = "Taki numer telefonu juz istnieje";
                }

            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            KTkomponent Ksiazka = new KTkomponent();
            try
            {
                int colourId = colourComboBox.SelectedIndex;
                if (colourId < 0)
                {
                    colourId = 0;
                }
                Ksiazka.ReplaceColour(dataGridView1, LpText, colourId);
                ErrorLabel.Text = "Ustawianie koloru: " + colourComboBox.SelectedItem + " na wierszu: " + LpText.Text;
            }
            catch
            {
                ErrorLabel.Text = "Nie odpowiednia liczba porzątkowa";
            }

        }

        // komponent od tego miejsca w dol
    }
}
