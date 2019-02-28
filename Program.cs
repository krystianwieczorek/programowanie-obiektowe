using System;



namespace PO_lab1
{
    //Zad_1
   public class Samochod {
        private string marka, model;
        private int ile_drzwi;
        private double pojemnosc_silnika, srednie_spalanie;
        private static int ilosc_samochodow = 0;

        //konstruktor domyslny:
        public Samochod() {
            marka = "nieznana marka";
            model = "nieznany model";
            ile_drzwi = 0;
            pojemnosc_silnika = 0.0;
            srednie_spalanie = 0.0;
            ilosc_samochodow = ilosc_samochodow + 1;
        }

        //konstruktor parametryczny:
        public Samochod(string _marka, string _model, int _ile_drzwi, double _pojemnosc_silnika, double _srednie_spalanie ) {
            marka = _marka;
            model = _model;
            ile_drzwi = _ile_drzwi;
            pojemnosc_silnika = _pojemnosc_silnika;
            srednie_spalanie = _srednie_spalanie;
            ilosc_samochodow = ilosc_samochodow + 1;
        }

        //metody klasy:
        private double ObliczSpalanie(double dlugoscTrasy) {
            return (srednie_spalanie * dlugoscTrasy) / 100;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa) {
            double x = ObliczSpalanie(dlugoscTrasy);
            return x * cenaPaliwa;
        }

        public void WypiszInfo() {
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Ilość Drzwi: " + ile_drzwi);
            Console.WriteLine("Pojemnosc Silnika: " + pojemnosc_silnika);
            Console.WriteLine("Srednie Spalanie: " + srednie_spalanie);
        }

        public static void WypiszIloscSamochodow() {
            Console.WriteLine("Ilość Samochodów: " + ilosc_samochodow);
        }

        // wlasciwosci klasy:
        public string Marka
        {
            get {return marka;}
            set { marka = value;}
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



    class Program{
        static void Main(string[] args){

            Samochod s1 = new Samochod();
            s1.WypiszInfo();
            s1.Marka = "Fiat";
            s1.Model = "126p";
            s1.Ile_drzwi = 2;
            s1.Pojemnosc_silnika = 650;
            s1.Srednie_spalanie = 6.0;
            s1.WypiszInfo();
            Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);
            s2.WypiszInfo();
            double kosztPrzejazdu = s2.ObliczKosztPrzejazdu(30.5, 4.85);
            Console.WriteLine("Koszt przejazdu: " + kosztPrzejazdu);
            Samochod.WypiszIloscSamochodow();
            Console.ReadKey();

            }
        }
}

