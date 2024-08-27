using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikPatikafy
{
    public class Person
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Sale { get; set; }
        public override string ToString()
        {
            return $"Adı: {Name}, Müzik Türü: {Genre}, Çıkış Yılı {Year}, Satış Sayısı: Yaklaşık {Sale} milyon";
        }
    }
}
