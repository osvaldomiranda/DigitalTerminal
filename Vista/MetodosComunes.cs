using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vista
{
    class MetodosComunes
    {
        public string formatearRut(string rut)
        {
            int cont = 0;
            string format;
            if (rut.Length == 0)
            {
                return "";
            }
            else
            {
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                format = "-" + rut.Substring(rut.Length - 1);
                for (int i = rut.Length - 2; i >= 0; i--)
                {
                    format = rut.Substring(i, 1) + format;
                    cont++;
                    if (cont == 3 && i != 0)
                    {
                        format = "" + format;
                        cont = 0;
                    }
                }
                return format;
            }
        }

        public Int32 getMontoConIva(decimal montoNeto)
        {
            Int32 montoConIva = 0;
            montoConIva = Convert.ToInt32(montoNeto * Convert.ToDecimal(1.19));
            return montoConIva;
        }

        public Decimal getMontoSinIva(decimal montoBruto)
        {
            Decimal montoSinIva = 0;
            montoSinIva = Convert.ToDecimal(montoBruto / Convert.ToDecimal(1.19));
            montoSinIva = Decimal.Round(montoSinIva, 4);
            return montoSinIva;
        } 

    }
}
