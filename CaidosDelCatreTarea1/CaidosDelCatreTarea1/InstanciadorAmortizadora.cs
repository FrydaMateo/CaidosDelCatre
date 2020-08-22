using System;
using System.Collections.Generic;
using System.Text;

namespace CaidosDelCatreTarea1
{
    public class InstanciadorAmortizadora
    {
        public static IAmortizable ObtenerAmortizadora(string sistema)
        {
            switch (sistema.ToLower())
            {
                case "americano":
                    return new SistemaAmericano();
                case "frances":
                    return new SistemaFrances();
                case "aleman":
                    return new SistemaAleman();
                default: throw new ArgumentException("El tipo de sistema ingresado no existe");
            }
        }
    }
}
