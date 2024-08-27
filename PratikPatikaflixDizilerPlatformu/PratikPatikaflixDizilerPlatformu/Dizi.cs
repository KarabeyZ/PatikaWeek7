using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikPatikaflixDizilerPlatformu
{
    public class Dizi
    {
        public string Name {  get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Platform { get; set; }


        public override string ToString()
        {
            return $"Dizinin Adı: {Name}, Yapım Yılı: {Year}, Dizi Türü: {Genre}, Dizi Yönetmeni: {Director}, Dizi Platformu {Platform}";
        }
    }
    public class KomediDizi : Dizi
    {
        public override string ToString()
        {
            return $"Dizinin Adı: {Name}, Dizi Türü: {Genre}, Dizi Yönetmeni: {Director}";
        }
    }
}
