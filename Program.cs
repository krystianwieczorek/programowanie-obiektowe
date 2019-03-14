using System;



namespace PO_lab1
{
    //Zad_1
    public class Samochod
    {
        private string marka, model;
        private int ile_drzwi;
        private double pojemnosc_silnika, srednie_spalanie;
        private static int ilosc_samochodow = 0;

        //konstruktor domyslny:
        public Samochod()
        {
            marka = "nieznana marka";
            model = "nieznany model";
            ile_drzwi = 0;
            pojemnosc_silnika = 0.0;
            srednie_spalanie = 0.0;
            //ilosc_samochodow = ilosc_samochodow + 1;
        }

        //konstruktor parametryczny:
        public Samochod(string _marka, string _model, int _ile_drzwi, double _pojemnosc_silnika, double _srednie_spalanie)
        {
            marka = _marka;
            model = _model;
            ile_drzwi = _ile_drzwi;
            pojemnosc_silnika = _pojemnosc_silnika;
            srednie_spalanie = _srednie_spalanie;
            ilosc_samochodow = ilosc_samochodow + 1;
        }

        //metody klasy:
        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return (srednie_spalanie * dlugoscTrasy) / 100;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            double x = ObliczSpalanie(dlugoscTrasy);
            return x * cenaPaliwa;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Ilość Drzwi: " + ile_drzwi);
            Console.WriteLine("Pojemnosc Silnika: " + pojemnosc_silnika);
            Console.WriteLine("Srednie Spalanie: " + srednie_spalanie);
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine("Ilość Samochodów: " + ilosc_samochodow);
        }

        // wlasciwosci klasy:
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Ile_drzwi
        {
            get { return ile_drzwi; }
            set { ile_drzwi = value; }
        }

        public double Srednie_spalanie
        {
            get { return srednie_spalanie; }
            set { srednie_spalanie = value; }
        }

        public double Pojemnosc_silnika
        {
            get { return pojemnosc_silnika; }
            set { pojemnosc_silnika = value; }
        }


    }

    //Zad_2
    class Garaz
    {
        private string adres;
        private int pojemnosc;
        private int liczbaSamochodow = 0;
        private Samochod[] samochody;

        public string Adres
        {

            get { return adres; }
            set { adres = value; }

        }

        public int Pojemnosc
        {

            get { return pojemnosc; }
            set { pojemnosc = value; samochody = new Samochod[pojemnosc]; }
        }

        public Garaz()
        {

            adres = "nieznany";
            pojemnosc = 0;
            samochody = null;
        }

        public Garaz(string _adres, int _pojemnosc)
        {

            adres = _adres;
            pojemnosc = _pojemnosc;
            samochody = new Samochod[_pojemnosc];
        }

        public void WprowadzSamochod(Samochod samochod)
        {

            if (pojemnosc == liczbaSamochodow)
            {
                Console.WriteLine("garaż jest pełny");
            }

            else
            {
                samochody[liczbaSamochodow] = samochod;
                liczbaSamochodow++;
            }

        }

        public Samochod WyprowadzSamochod()
        {

            if (liczbaSamochodow == 0)
            {
                Console.WriteLine("Garaz jest pusty");
            }

            else
            {
                liczbaSamochodow--;
                samochody[liczbaSamochodow] = null;


            }
            return samochody[liczbaSamochodow];
        }

        public void WypiszInfo()
        {

            Console.WriteLine("Adres Garażu:" + adres);
            Console.WriteLine("Pojemność Garażu:" + pojemnosc);
            Console.WriteLine("Liczba Samochodów w garażu:" + liczbaSamochodow);

            for (int i = 0; i < liczbaSamochodow; i++)
            {
                samochody[i].WypiszInfo();
            }

        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            Samochod s1 = new Samochod("Fiat", "126p", 2, 650, 6.0);
            Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);
            Garaz g1 = new Garaz();
            g1.Adres = "ul. Garażowa 1";
            g1.Pojemnosc = 1;
            Garaz g2 = new Garaz("ul. Garażowa 2", 2);
            g1.WprowadzSamochod(s1);
            g1.WypiszInfo();
            g1.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s1);
            g2.WypiszInfo();
            g2.WyprowadzSamochod();
            g2.WypiszInfo();
            g2.WyprowadzSamochod();
            g2.WyprowadzSamochod();
            Console.ReadKey();

        }
    }
}

