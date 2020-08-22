﻿using System;
using System.Dynamic;
using System.Runtime.InteropServices;
using BLCaidosDelCatre;
using CaidosDelCatreTarea1;

namespace CaidosDelCatreClase1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Monto = SolicitarMonto();
            double Interes = SolicitarInteres();
            int Cuotas = SolicitarCuotas();
            string TipoAmortizacion = SolicitarAmortizacion();

            IAmortizable amortizacion = InstanciadorAmortizadora.ObtenerAmortizadora(TipoAmortizacion);

            var dic = amortizacion.CalcularPagos(Monto, Cuotas, Interes);

            var exportador = new ExportadorHTML();

            exportador.ExportarPagos(dic);
        }

        private static string SolicitarAmortizacion()
        {
            Console.WriteLine("Ingrese el tipo de amortización que desea utilizar");
            return Console.ReadLine();
        }

        private static int SolicitarCuotas()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Ingrese la cantidad de cuotas");
                    return int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("La cantidad de cuotas debe ser un número");
                }
            }
        }

        private static double SolicitarInteres()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Ingrese el interes del prestamo (como %)");
                    return double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("El interes debe ser un número");
                }
            }
        }

        private static double SolicitarMonto()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Ingrese el monto del prestamo");
                    return double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("El monto debe ser un número");
                }
            }
        }
    }
}