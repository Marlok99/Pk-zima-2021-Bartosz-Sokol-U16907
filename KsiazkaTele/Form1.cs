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

            LoadTextFile(null, null, dataGridView1);
            
            
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
            Data data = new Data(ImieText.Text, NazwiskoText.Text, NrTelText.Text);
            SetText("0", data, dataGridView1, ErrorLabel);
            AddToTextFile(data,colourComboBox.SelectedIndex,ErrorLabel);
            
        }

        private void Usun_Click(object sender, EventArgs e)
        {
            RemoveAt(dataGridView1, LpText,ErrorLabel);
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
            Data data = new Data(ImieText.Text, NazwiskoText.Text, NrTelText.Text);
            if (LpText.Text != "")
            {
                RemoveAt(dataGridView1,LpText,null,data);
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            try
            {
                int colourId = colourComboBox.SelectedIndex;
                if (colourId < 0)
                {
                    colourId = 0;
                }
                ReplaceColour(dataGridView1, LpText, colourId);
                ErrorLabel.Text = "Ustawianie koloru: " + colourComboBox.SelectedItem + " na wierszu: " + LpText.Text;
            }
            catch
            {
                ErrorLabel.Text = "Nie odpowiednia liczba porzątkowa";
            }
            
        }

        // komponent od tego miejsca w dol

        public void SetColor(int position, DataGridView dataGrid, int colourId)
        {
            int i = 0;
            Color colour = Color.White;
            if (colourId == 0)
            {
                colour = Color.LightGreen;
            }
            else if (colourId == 1)
            {
                colour = Color.Aqua;
            }
            else if (colourId == 2)
            {
                colour = Color.Red;
            }
            else if (colourId == 3)
            {
                colour = Color.Pink;
            }
            foreach (DataGridViewRow Myrow in dataGrid.Rows)
            {
                if (i == position)
                {
                    Myrow.DefaultCellStyle.BackColor = colour;
                }
                i++;
            }
        }

        public void ReplaceColour(DataGridView dataGrid,TextBox lpBox, int colourId = 0, Label errorTextMesage = null, string filepath = null, string filename = null )
        {
            int pos = 0;
            colourId += 1;
            string newFileString = "";
            try
            {
                pos = int.Parse(lpBox.Text);
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
                ClearFile(filepath, filename);
                for (int i = 0; i < codes.Length; i++)
                {
                    if (i == pos)
                    {
                        newFileString = newFileString + "$" + codes[i].Remove(codes[i].Length-1) + colourId.ToString();
                    }
                    else
                    {
                        newFileString = newFileString + "$" + codes[i];
                    }
                }
                File.WriteAllText(filepath + filename, newFileString);
                LoadTextFile(null, null, dataGrid);
            }
        }

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
                lpString = "1";
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
                n = lp;
            }
            if (dataGrid.RowCount >= lp)
            {
                dataGrid.Rows[n].Cells[0].Value = lp;
                dataGrid.Rows[n].Cells[1].Value = imie;
                dataGrid.Rows[n].Cells[2].Value = nazwisko;
                dataGrid.Rows[n].Cells[3].Value = nrtel;
            }
        }

        /// <summary>
        /// cos
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="filename"></param>
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



        public void RemoveAt(DataGridView dataGrid,TextBox LpBox, Label errorTextMesage = null, Data optionalToReplace = null, string filepath = null, string filename = null )
        {
            int position = 0;
            string newFileString = "";
            string removed = "";
            try
            {
                position = int.Parse(LpBox.Text);
                if (errorTextMesage != null)
                {
                    errorTextMesage.Text = "";
                }
            }
            catch
            {
                position = 0;
                if (errorTextMesage != null)
                {
                    errorTextMesage.Text = "Error podano złą liczbę porządkową";
                }
            }
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
                ClearFile(filepath, filename);
                for (int i = 0; i < codes.Length; i++)
                {
                    if (i != position)
                    {
                        newFileString = newFileString + "$" + codes[i];
                    }
                    else
                    {
                        if (optionalToReplace != null)
                        {
                            newFileString = newFileString + "$" + optionalToReplace.imie + "/" + optionalToReplace.nazwiskko + "/" + optionalToReplace.nrtel+"/"+"0";
                        }
                        removed = codes[i];
                    }
                }
                if (errorTextMesage != null && optionalToReplace == null)
                {
                    if (removed == "")
                    {
                        removed = "Nic nie usunięto";
                    }
                    errorTextMesage.Text = "Usunięto : " + removed;
                }
                File.WriteAllText(filepath + filename, newFileString);
                LoadTextFile(null, null, dataGrid);
            }
        }

        public void LoadTextFile(string filename = null, string filepath = null, DataGridView dataGrid = null)
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
                    int i = 0;
                    foreach (string d in codes)
                    {
                        i++;
                        string[] divided = d.Split('/');
                        Data data = new Data(divided[0], divided[1], divided[2]);
                        SetText("0", data, dataGrid);
                    }
                    i = 0;
                    foreach (string d in codes)
                    {
                        i++;
                        string[] divided = d.Split('/');
                        if (divided[3] == "")
                        {
                            divided[3] = "0";
                        }
                        SetColor(i-1, dataGrid, int.Parse(divided[3])-1);
                    }

                }
                
            }
        }
        public void AddToTextFile(Data data,int colourId,Label showOutput = null, string filename = null, string filepath = null)
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

            if(colourId < 0)
            {
                colourId = 0;
            }

            string jsonString = data.imie + "/" + data.nazwiskko + "/" + data.nrtel + "/" + colourId;

            if(showOutput != null)
            {
                showOutput.Text = "Dodano : " + jsonString;
            }
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


    }
}
