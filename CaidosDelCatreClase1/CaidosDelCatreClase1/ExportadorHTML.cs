using CaidosDelCatreTarea1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace BLCaidosDelCatre
{

    internal class ExportadorHTML 
    {

        public Boolean ExportarPagos(IEnumerable<Pago> pagos)
        {
            string htmlTable = ObtenerHeaderHTMLTable();
            htmlTable = ConstruirTabla(htmlTable, pagos);
            htmlTable = CerrarHTML (htmlTable);

            using (StreamWriter writer = new StreamWriter("tabla.html"))
            {
                writer.WriteLine(htmlTable);
            }
            return true;
        }

        private string CerrarHTML(string htmlTable)
        {
            htmlTable += "</body>" + Environment.NewLine;
            htmlTable += "</html>" + Environment.NewLine;


            return htmlTable;
        }

        private string ConstruirTabla(string htmlTable, IEnumerable<Pago> pagos)
        {
            htmlTable += "<table>" + Environment.NewLine;
            int i = 0;
            foreach (var item in pagos)
            {
                htmlTable += "<tr>" + Environment.NewLine;
                htmlTable = AgregarEntreTD(htmlTable, i.ToString());
                htmlTable = AgregarEntreTD(htmlTable, item.Monto.ToString());
                htmlTable = AgregarEntreTD(htmlTable, item.TotalRestante.ToString());
                i++;

                htmlTable += "</tr>" + Environment.NewLine;
            }
            htmlTable += "</table>" + Environment.NewLine;

            return htmlTable;
        }

        private string ObtenerHeaderHTMLTable()
        {
            var html = "<!DOCTYPE html>" + Environment.NewLine;
            html += "<html>" + Environment.NewLine ;
            html += "<body>" + Environment.NewLine ;
            html += "<table>" + Environment.NewLine;


            return html;
        }

        private string AgregarEntreTD( string htmlTable, string value)
        {
            htmlTable += "<td>" + Environment.NewLine;
            htmlTable += value + Environment.NewLine;
            htmlTable += "</td>" + Environment.NewLine;

            return htmlTable;
        }
    }
}

