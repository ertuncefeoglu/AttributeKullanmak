using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeKullanmak
{
    class Program
    {
        public static void Main(string[] args)
        {
            var kullanici = new Kullanici { Adi = "Ertunç" };
            //var kullanici = new Kullanici { Adi = "Ertunç" };

            if (KullaniciKontrol.Kontrol(kullanici))
            {
                Console.WriteLine("Kullanıcı doğru oluşturuldu");
            }
            else
            {
                Console.WriteLine("Kullanıcı yanlış oluşturuldu");
            }

            Console.ReadKey();
        }

    }
}
