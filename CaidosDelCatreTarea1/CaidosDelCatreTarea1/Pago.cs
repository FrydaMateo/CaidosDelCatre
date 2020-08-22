using System;
using System.Collections.Generic;
using System.Text;

namespace CaidosDelCatreTarea1
{
    public class Pago
    {
        public Pago(double monto, double totalRestante)
        {
            this.Monto = monto;
            this.TotalRestante = totalRestante;
        }

        public double Monto { get; set; }
        public double TotalRestante { get; set; }
    }
}
