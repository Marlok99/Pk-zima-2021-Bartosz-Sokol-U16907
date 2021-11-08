using System;
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


            LoadJsonFile(null, null, dataGridView1);
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
            Data data = new Data(ImieText.Text, NazwiskoText.Text, NrTelText.Text);

            if (!CheckIfDividersUsed(data))
            {
                SetText("", data, dataGridView1, ErrorLabel);
                AddToTextFile(data);
            }
            else
            {
                ErrorLabel.Text = "Użyto zakazanego znaku!";
            }

        }

        private void Usun_Click(object sender, EventArgs e)
        {
            RemoveAt(dataGridView1, LpText, ErrorLabel);
        }



        bool przycisk = true;
        private void TrybEdycji_Click(object sender, EventArgs e)
        {
            przycisk = !przycisk;
            Dodaj.Visible = przycisk;
            Usun.Enabled = !przycisk;
            podmien.Visible = !przycisk;
            label4.Enabled = !przycisk;
            LpText.Enabled = !przycisk;

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
            Data data = new Data(ImieText.Text, NazwiskoText.Text, NrTelText.Text);

            if (!CheckIfDividersUsed(data))
            {
                if (LpText.Text != "0" || LpText.Text != "")
                {

                    RemoveAt(dataGridView1, LpText, null, data);
                }
            }
            else
            {
                ErrorLabel.Text = "Użyto zakazanego znaku!";
            }
        }
        // komponent od tego miejsca w dol
        private void SetText(string lpString, Data data, DataGridView dataGrid, Label errorTextMesage = null)
        {
            string imie = data.imie;
            string nazwisko = data.nazwiskko;
            string nrtel = data.nrtel;
            int lp = 0;
            int n;
            if (imie == "")
            {
                imie = "Nie podano";
            }
            if (nazwisko == "")
            {
                nazwisko = "Nie podano";
            }
            if (nrtel == "-1" || nrtel == "")
            {
                nrtel = "Nie podano";
            }
            if (lpString == "")
            {
                lpString = "0";
            }

            try
            {
                lp = int.Parse(lpString);
                if (errorTextMesage != null)
                {
                    errorTextMesage.Text = "";
                }
            }
            catch
            {
                lp = 0;
                if (errorTextMesage != null)
                {
                    errorTextMesage.Text = "Error podano złą liczbę porządkową";
                }

            }

            if (lp < 1)
            {
                lp = dataGridView1.RowCount;
                n = dataGridView1.Rows.Add();
            }
            else
            {
                n = lp - 1;
            }
            if (dataGrid.RowCount >= lp)
            {
                dataGrid.Rows[n].Cells[0].Value = lp;
                dataGrid.Rows[n].Cells[1].Value = imie;
                dataGrid.Rows[n].Cells[2].Value = nazwisko;
                dataGrid.Rows[n].Cells[3].Value = nrtel;
            }

        }

        private void ClearFile(string filepath = null, string filename = null)
        {
            filepath = CheckFilePath(filepath);
            filename = CheckFileName(filename);

            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }
            if (!File.Exists(filepath + filename))
            {
                File.CreateText(filepath + filename);
            }

            File.WriteAllText(filepath + filename, "");

        }

        public bool CheckIfDividersUsed(Data data)
        {
            string imie = data.imie;
            string nazwisko = data.nazwiskko;
            string nrtel = data.nrtel;

            if (imie.Contains("$") || imie.Contains("/") || nazwisko.Contains("$") || nazwisko.Contains("/") || nrtel.Contains("$") || nrtel.Contains("/"))
            {
                return true;
            }

            return false;
        }

        private void RemoveAt(DataGridView dataGrid,TextBox textBox, Label errorTextMesage = null, Data optionalToReplace = null, string filepath = null, string filename = null )
        {
            int pos = 0;
            string newFileString = "";
            string removed = "";
            try
            {
                pos = int.Parse(textBox.Text);
                if (errorTextMesage != null)
                {
                    errorTextMesage.Text = "";
                }
            }
            catch
            {
                pos = 0;
                if (errorTextMesage != null)
                {
                    errorTextMesage.Text = "Error podano złą liczbę porządkową";
                }

            }
            if (pos != 0)
            {
                if (dataGrid != null)
                {
                    dataGrid.DataSource = null;
                    dataGrid.Rows.Clear();

                    filepath = CheckFilePath(filepath);
                    filename = CheckFileName(filename);

                    if (!Directory.Exists(filepath))
                    {
                        Directory.CreateDirectory(filepath);
                    }
                    if (!File.Exists(filepath + filename))
                    {
                        File.CreateText(filepath + filename);
                    }

                    string loadString = File.ReadAllText(filepath + filename);
                    if (loadString.StartsWith("$"))
                    {
                        loadString = loadString.Substring(1);
                    }

                    string[] codes = loadString.Split('$');
                    ClearFile(filepath,filename);
                    for (int i= 0;i< codes.Length; i++)
                    {
                        if (i != pos)
                        {
                            newFileString = newFileString + "$" + codes[i];
                        }
                        else
                        {
                            if(optionalToReplace != null)
                            {
                                newFileString = newFileString + "$" + optionalToReplace.imie + "/" + optionalToReplace.nazwiskko + "/" + optionalToReplace.nrtel;
                            }
                            removed = codes[i];
                        }
                    }
                    
                    if (errorTextMesage != null && optionalToReplace == null)
                    {
                        if(removed == "")
                        {
                            removed = "Nic nie usunięto";
                        }
                        errorTextMesage.Text = "Usunięto : " + removed;
                    }
                    File.WriteAllText(filepath + filename, newFileString);
                    LoadJsonFile(null, null, dataGrid);
                }
            }
            
        }

        public void LoadJsonFile(string filename = null, string filepath = null, DataGridView dataGrid = null)
        {
            if (dataGrid != null)
            {
                filepath = CheckFilePath(filepath);
                filename = CheckFileName(filename);

                if (!Directory.Exists(filepath))
                {
                    Directory.CreateDirectory(filepath);
                }
                if (!File.Exists(filepath + filename))
                {
                    File.CreateText(filepath + filename);
                }

                string loadString = File.ReadAllText(filepath + filename);
                if (loadString.StartsWith("$"))
                {
                    loadString = loadString.Substring(1);
                }
                if(loadString != "")
                {
                    string[] codes = loadString.Split('$');

                    foreach (string d in codes)
                    {
                        string[] divided = d.Split('/');
                        Data data = new Data(divided[0], divided[1], divided[2]);
                        SetText("0", data, dataGrid);
                    }
                }
                
            }
        }
        private void AddToTextFile(Data data, string filename = null, string filepath = null)
        {

            filepath = CheckFilePath(filepath);
            filename = CheckFileName(filename);

            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }
            if (!File.Exists(filepath + filename))
            {
                File.CreateText(filepath + filename);
            }

            string jsonString = data.imie + "/" + data.nazwiskko + "/" + data.nrtel;

            ErrorLabel.Text = "Dodano : " + jsonString;

            

            string loadString = File.ReadAllText(filepath + filename) + "$" + jsonString ;
            if (loadString.StartsWith("$"))
            {
                loadString = loadString.Substring(1);
            }

            File.WriteAllText(filepath + filename, loadString);
        }

        private string CheckFilePath(string filepath)
        {
            if (filepath == null)
            {
                filepath = Application.LocalUserAppDataPath + "/Save/";
            }
            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }

            return filepath;
        }
        private string CheckFileName(string filename)
        {
            if (filename == null)
            {
                filename = "tmp.txt";
            }
            else if (!(filename.Substring(4) == ".txt"))
            {
                filename = filename + ".txt";
            }

            return filename;
        }
    }
}
