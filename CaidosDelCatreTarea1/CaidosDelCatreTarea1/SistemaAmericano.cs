using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

namespace CaidosDelCatreTarea1
{
    public class SistemaAmericano : IAmortizable
    {
        public List<Pago> CalcularPagos(double monto, int cantidadPagos, double interes)
        {
            var dic = new List<Pago>();
            for (int i = 0; i < cantidadPagos; i++)
            {
                var cuota = monto / cantidadPagos;
                var pago = new Pago(Math.Round( cuota, 2), Math.Round( monto - cuota * (i + 1), 2));
                dic.Add(pago);
            }

            return dic;
        }
    }
}
