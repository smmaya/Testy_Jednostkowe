using System;
using System.Text.RegularExpressions;

namespace Lab_2_Testy_Jednostkowe
{ 
    public class PESELWalidator
    {
        protected int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        protected int[] pesel;
        private string numerPesel;

        public PESELWalidator(String pesel)
        {
            WczytajPesel(pesel);
        }

        public void WczytajPesel(String pesel)
        {
            numerPesel = pesel;
        }

        public int SumaKontrolna()
        {
            int suma = 0;

            for (int i = 0; i < numerPesel.Length-1; i++)
            {
                suma += int.Parse(numerPesel[i].ToString()) * wagi[i];
            }
            return (10 - (suma % 10)) % 10;
        }

        public String DataUrodzenia()
        {
            return numerPesel.Substring(0, 2);;
        }

        public String Plec()
        {
            if (Convert.ToInt32(numerPesel[9]) % 2 == 0)
                return "k";
            return "m";
        }

        public Boolean SprawdzPesel()
        {
            string pattern = @"^[0-9]{11}$";
            return Regex.Match(numerPesel, pattern).Value.Length == 11;
        }

    }
}