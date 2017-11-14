using System;
namespace Akademia1
{
    public class Samochod
    {
        
        public string marka;
        public string model;
        public int rok;
        public string kolor;
        public double pojSil;
        public Silnik silnikSamochodu;

        public Samochod()
        {
            silnikSamochodu = new Silnik();

        }
        public Samochod(string _marka, string _model) : this()
        {
            this.marka = _marka;
            this.model = _model;
        }
        public Samochod(string _marka, string _model, int _rok, string _kolor, double _pojSil, Silnik nowySilnik) 
        {
            silnikSamochodu = nowySilnik;
            this.marka = _marka;
            this.model = _model;
            this.rok = _rok;
            this.kolor = _kolor;
            this.pojSil = _pojSil;


        }
        public void Jedz()
        {
            Console.WriteLine(marka+"jedzie");
        }
    }
}
