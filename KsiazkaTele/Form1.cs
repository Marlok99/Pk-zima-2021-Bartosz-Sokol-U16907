using System;

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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // dodaj
        private void button1_Click(object sender, EventArgs e)
        {
            setText("0",ImieText.Text, NazwiskoText.Text, NrTelText.Text, dataGridView1);
        }

        private void Usun_Click(object sender, EventArgs e)
        {

        }


        // load
        private void button2_Click(object sender, EventArgs e)
        {

        }
        // save
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        bool przycisk = true;
        private void TrybEdycji_Click(object sender, EventArgs e)
        {
            przycisk = !przycisk;
            podmien.Visible = !przycisk;
            Dodaj.Visible = !przycisk;
            if (przycisk)
            {
                TrybEdycjiLabel.Text = "Tryb edycji : Włączony" ;
                podmien.Visible = true;
                Dodaj.Visible = false;
            }
            else
            {
                TrybEdycjiLabel.Text = "Tryb edycji : Wyłączony";
                podmien.Visible = false;
                Dodaj.Visible = true;
            }
        }

        private void podmien_Click(object sender, EventArgs e)
        {

            if (LpText.Text == "0")
            {

            }
            else
            {
                setText(LpText.Text, ImieText.Text, NazwiskoText.Text, NrTelText.Text, dataGridView1);
            }            
        }

        public void setText(string lpString,string imie, string nazwiskko, string nrtel, DataGridView dataGrid)
        {
            int n;
            if (imie == "")
            {
                imie = "Nie podano";
            }
            if (nazwiskko == "")
            {
                nazwiskko = "Nie podano";
            }
            if (nrtel == "")
            {
                nrtel = "Nie podano";
            }
            int lp = int.Parse(lpString);
            if (lp == 0)
            {
                lp = dataGridView1.RowCount;
                n = dataGridView1.Rows.Add();
            }
            else
            {
                n = lp-1;
            }
            if(dataGrid.RowCount >= lp)
            {
                
                dataGrid.Rows[n].Cells[0].Value = lp;
                dataGrid.Rows[n].Cells[1].Value = imie;
                dataGrid.Rows[n].Cells[2].Value = nazwiskko;
                dataGrid.Rows[n].Cells[3].Value = nrtel;
            }


            // nazwa komponentu do ktorego wpisac ,, text wpisywany

        }

        public void saveTofile(string filename = null, string filepath = null)
        {
            filename = checkFileName(filename);
            filepath = checkFilePath(filepath);

        }

        public void loadFromFile(string filename = null, string filepath = null)
        {
            filename = checkFileName(filename);
            filepath = checkFilePath(filepath);

        }

        private string checkFileName(string filename)
        {
            if (filename == null)
            {
                return "tmp.txt";
            }
            else if (filename.Substring(4) != ".txt")
            {
                return filename + ".txt";
            }

            return filename;
        }

        private string checkFilePath(string filepath)
        {
            
            
            // sprawdz czy istnieje jezeli nie to stworz lokaliacje

            return filepath;
        }

    }
}
