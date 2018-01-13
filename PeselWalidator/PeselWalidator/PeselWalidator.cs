using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeselWal
{
    public enum PlecEnum
    {
        Kobieta,
        Mezczyzna
    }
    public class PeselWalidator
    {
        protected int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        protected string pesel;

        public string DataUrodzenia
        {
            get
            {
                return pesel.Substring(0,6);
            }
        }

        public PeselWalidator(String pesel)
        {
            WczytajPesel(pesel);
        }

        public PeselWalidator()
        {
        }

        public void WczytajPesel(String pesel)
        {
            this.pesel = pesel;
        }

        public int SumaKontrolna()
        {
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                int tmpWaga = int.Parse(pesel[i].ToString()) * wagi[i];

                suma += int.Parse(tmpWaga.ToString().Last().ToString());
            }

            return 10 - int.Parse(suma.ToString().Last().ToString());
        }

        public string Plec
        {
            get
            {
                var plec = int.Parse(pesel.Substring(9, 1));

                if (plec % 2 == 0)
                    return PlecEnum.Kobieta.ToString();
                else
                    return PlecEnum.Mezczyzna.ToString();
            }
        }

        public Boolean SprawdzPesel()
        {
            bool isNumeric = pesel.All(char.IsDigit);

            if (pesel.Length == 11 && isNumeric)
                return true;

            return false;
        }

        public bool SprawdzIloscZnakow()
        {
            throw new NotImplementedException();
        }
    }
}
