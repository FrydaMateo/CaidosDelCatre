using System;
using System.Collections.Generic;
using System.Text;

namespace CaidosDelCatreTarea1
{
    public interface IAmortizable
    {
        List<Pago> CalcularPagos(double monto, int cantidadPagos, double interes);
    }
}
