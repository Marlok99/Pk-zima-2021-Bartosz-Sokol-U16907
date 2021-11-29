using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KsiazkaTele
{
    class KTkomponent
    {
        public KTkomponent()
        {
        }

        /// <summary>
        /// Wyswietlenie i dodanie koloru w samym datagridzie
        /// </summary>
        /// <param name="position"></param>
        /// <param name="dataGrid"></param>
        /// <param name="colourId"></param>
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
        /// <summary>
        /// Podmiana koloru w danym wierszu oraz pliku i wyswietlenie tego
        /// </summary>
        /// <param name="dataGrid"></param>
        /// <param name="lpBox"></param>
        /// <param name="colourId"></param>
        /// <param name="errorTextMesage"></param>
        /// <param name="filepath"></param>
        /// <param name="filename"></param>
        public void ReplaceColour(DataGridView dataGrid, TextBox lpBox, int colourId = 0, Label errorTextMesage = null, string filepath = null, string filename = null)
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
                        newFileString = newFileString + "$" + codes[i].Remove(codes[i].Length - 1) + colourId.ToString();
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
        /// <summary>
        /// Ustawianie tekstu w samym data gridzie z parametru Data.
        /// </summary>
        /// <param name="lpString"></param> string do liczby porzadkowej
        /// <param name="data"></param>
        /// <param name="dataGrid"></param>
        /// <param name="errorTextMesage"></param>
        public void SetText(string lpString, Data data, DataGridView dataGrid, Label errorTextMesage = null)
        {
            string imie = data.imie;
            string nazwisko = data.nazwiskko;
            string nrtel = data.nrtel;
            int lp = 0;
            int n;
            if (imie == string.Empty)
            {
                imie = "Nie podano";
            }
            if (nazwisko == string.Empty)
            {
                nazwisko = "Nie podano";
            }
            if (nrtel == "-1" || nrtel == string.Empty)
            {
                nrtel = "Nie podano";
            }
            if (lpString == string.Empty)
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
                lp = dataGrid.RowCount;
                n = dataGrid.Rows.Add();
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
        /// Zaladowanie pliku poczym ustawianie jego zawartości na pusta.
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="filename"></param>
        public void ClearFile(string filepath = null, string filename = null)
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


        /// <summary>
        /// Pobranie Stringa calego pliku poczym podzielenie go na wiersze by mozna było odczytać dane poczym usuwanie
        /// ich od wzgledu podanej zmiennej liczby porzadkowej znajdujacej sie w lpBox.
        /// Podanie optionalToReplace powoduje podmiane danych zamiast jej usuniecia w danym miejscu.
        /// </summary>
        /// <param name="dataGrid"></param>
        /// <param name="LpBox"></param>
        /// <param name="errorTextMesage"></param>
        /// <param name="optionalToReplace"></param>
        /// <param name="filepath"></param>
        /// <param name="filename"></param>
        public void RemoveAt(DataGridView dataGrid, TextBox LpBox, Label errorTextMesage = null, Data optionalToReplace = null, string filepath = null, string filename = null)
        {
            int position = 0;
            string newFileString = string.Empty;
            string removed = string.Empty;
            try
            {
                position = int.Parse(LpBox.Text);
                if (errorTextMesage != null)
                {
                    errorTextMesage.Text = string.Empty;
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
                            newFileString = newFileString + "$" + optionalToReplace.imie + "/" + optionalToReplace.nazwiskko + "/" + optionalToReplace.nrtel + "/" + "0";
                        }
                        removed = codes[i];
                    }
                }
                if (errorTextMesage != null && optionalToReplace == null)
                {
                    if (removed == string.Empty)
                    {
                        removed = "Nic nie usunięto";
                    }
                    errorTextMesage.Text = "Usunięto : " + removed;
                }
                File.WriteAllText(filepath + filename, newFileString);
                LoadTextFile(null, null, dataGrid);
            }
        }
        /// <summary>
        /// Zaladowanie z pliku tekstowego wszystkiego i wyświetlenie go w data gridzie
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="filepath"></param>
        /// <param name="dataGrid"></param>
        public void LoadTextFile(string filename = null, string filepath = null, DataGridView dataGrid = null)
        {
            if (dataGrid != null)
            {
                filepath = CheckFilePath(filepath);
                filename = CheckFileName(filename);


                if (!File.Exists(filepath + filename))
                {
                    File.CreateText(filepath + filename);
                }

                string loadString = File.ReadAllText(filepath + filename);
                if (loadString.StartsWith("$"))
                {
                    loadString = loadString.Substring(1);
                }
                if (loadString != string.Empty)
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
                        if (divided[3] == string.Empty)
                        {
                            divided[3] = "0";
                        }
                        SetColor(i - 1, dataGrid, int.Parse(divided[3]) - 1);
                    }

                }

            }
        }
        /// <summary>
        /// Dodanie do pliku tekstowego danych.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="colourId"></param>
        /// <param name="showOutput"></param>
        /// <param name="filename"></param>
        /// <param name="filepath"></param>
        public void AddToTextFile(Data data, int colourId, Label showOutput = null, string filename = null, string filepath = null)
        {

            filepath = CheckFilePath(filepath);
            filename = CheckFileName(filename);

            if (!File.Exists(filepath + filename))
            {
                File.CreateText(filepath + filename);
            }

            if (colourId < 0)
            {
                colourId = 0;
            }

            string jsonString = data.imie + "/" + data.nazwiskko + "/" + data.nrtel + "/" + colourId;

            if (showOutput != null)
            {
                showOutput.Text = "Dodano : " + jsonString;
            }
            string loadString = File.ReadAllText(filepath + filename) + "$" + jsonString;
            if (loadString.StartsWith("$"))
            {
                loadString = loadString.Substring(1);
            }

            File.WriteAllText(filepath + filename, loadString);
        }
        /// <summary>
        /// Sprawdzenie czy string filepath jest poprawny i czy istnieje jezeli nie to zostanie utworzony
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public string CheckFilePath(string filepath)
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

        /// <summary>
        /// Sprawdzenie czy string filename jest poprawny jezeli nie jest to jest oddawane .txt.
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public string CheckFileName(string filename)
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
        /// <summary>
        /// Sprawdzenie czy zostaly uzyte zakazane znaki specjalne jezeli zostaly to zwraca prawde.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
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
        /// <summary>y występuje już nr telefonu jezeli istnieje to zwraca true
        /// Sprawdza cz
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filename"></param>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public bool CheckIfexists(Data data, string filename = null, string filepath = null)
        {
            string imie = data.imie;
            string nazwisko = data.nazwiskko;
            string nrtel = data.nrtel;

            filepath = CheckFilePath(filepath);
            filename = CheckFileName(filename);


            if (!File.Exists(filepath + filename))
            {
                File.CreateText(filepath + filename);
            }

            string loadString = File.ReadAllText(filepath + filename);
            if (loadString.StartsWith("$"))
            {
                loadString = loadString.Substring(1);
            }
            if (loadString != string.Empty)
            {
                string[] codes = loadString.Split('$');
                int i = 0;
                foreach (string row in codes)
                {
                    i++;
                    string[] column = row.Split('/');
                    if (/*column[0] == imie || column[1] == nazwisko ||*/ column[2] == nrtel)
                    {
                        return true;
                    }
                }

            }

            return false;
        }


    
}
}
