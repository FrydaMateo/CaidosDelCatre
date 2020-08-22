using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace CaidosDelCatreTarea1
{
    public class SistemaFrances : IAmortizable
    {
        public List<Pago> CalcularPagos(double monto, int cantidadPagos, double interes)
        {
            var dic = new List<Pago>();
            for (int i = 0; i < cantidadPagos; i++)
            {
                var cuota = (monto * (1 + interes / 100)) / cantidadPagos;
                var pago = new Pago(Math.Round(cuota, 2), Math.Round(monto / cantidadPagos * i, 2));
                dic.Add(pago);
            }

            return dic;
        }
    }
}
