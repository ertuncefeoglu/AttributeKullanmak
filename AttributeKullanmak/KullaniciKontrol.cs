using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeKullanmak
{
    public static class KullaniciKontrol
    {
        public static bool Kontrol(Kullanici kullanici)
        {
            var retVal = true;

            var props = kullanici.GetType().GetProperties();

            foreach (var propertyinfo in props)
            {
                if (propertyinfo.GetCustomAttributes(typeof(BosOlamazAttribute), true).Any())
                {
                    var val = propertyinfo.GetValue(kullanici) as string;
                    if (string.IsNullOrEmpty(val))
                    {
                        retVal = false;
                    }
                }

            }

            return retVal;
        }
    }
}
