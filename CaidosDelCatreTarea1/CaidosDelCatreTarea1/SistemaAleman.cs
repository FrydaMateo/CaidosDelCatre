using System;
using System.Collections.Generic;
using System.Text;

namespace CaidosDelCatreTarea1
{
    public class SistemaAleman : IAmortizable
    {
        public List<Pago> CalcularPagos(double monto, int cantidadPagos, double interes)
        {
            var dic = new List<Pago>();
            for (int i = 0; i < cantidadPagos; i++)
            {
                var capital = (monto / cantidadPagos);
                var cuota = capital * (1 + interes / 100);

                var pago = new Pago(Math.Round(cuota, 2), Math.Round(monto - capital * (i + 1), 2));
                dic.Add(pago);
            }

            return dic;
        }
    }
}
