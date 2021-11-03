
namespace KsiazkaTele
{
    public class Data
    {
        public string imie { get; set; }
        public string nazwiskko { get; set; }
        public string nrtel { get; set; }

        public Data(string Imie,string Nazwisko,string NrTel)
        {
            imie = Imie;
            nazwiskko = Nazwisko;
            nrtel = NrTel;
        }
    }
}
