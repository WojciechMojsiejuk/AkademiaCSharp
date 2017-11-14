using System;
namespace Akademia1
{
    public class Silnik
    {
        public string producent;
        public int rokProdukcji;

        public Silnik()
        {

        }
        public Silnik(string _producent, int _rokProdukcji)
        {
            this.producent = _producent;
            this.rokProdukcji = _rokProdukcji;
        }
    }
}
