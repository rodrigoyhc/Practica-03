using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_03
{
    public partial class FRMFechas : Form
    {
        public FRMFechas()
        {
            InitializeComponent();
        }

        private void BTNCurp_Click(object sender, EventArgs e)
        {
            string fecha = TXTCurp.Text.Substring(4, 6);
            string sexo = TXTCurp.Text.Substring(10, 1);
            string estado = TXTCurp.Text.Substring(11, 2);

            string fecha1;
            string sexo1 = "";
            string estado1 = "";

            switch (estado)
            {
                case "AS":
                    estado1 = "Aguascalientes";
                    break;
                case "BC":
                    estado1 = "Baja California";
                    break;
                case "BS":
                    estado1 = "Baja California Sur";
                    break;
                case "CC":
                    estado1 = "Campeche";
                    break;
                case "CL":
                    estado1 = "Coahuila";
                    break;
                case "CM":
                    estado1 = "Colima";
                    break;
                case "CS":
                    estado1 = "Chiapas";
                    break;
                case "CH":
                    estado1 = "Chihuahua";
                    break;
                case "CDMX":
                    estado1 = "Ciudad de Mexico";
                    break;
                case "DG":
                    estado1 = "Durango";
                    break;
                case "GT":
                    estado1 = "Guanajuato";
                    break;
                case "GR":
                    estado1 = "Guerrero";
                    break;
                case "HG":
                    estado1 = "Hidalgo";
                    break;
                case "JC":
                    estado1 = "Jalisco";
                    break;
                case "MC":
                    estado1 = "Mexico";
                    break;
                case "MN":
                    estado1 = "Michoacan";
                    break;
                case "MS":
                    estado1 = "Morelos";
                    break;
                case "NT":
                    estado1 = "Nayarit";
                    break;
                case "NL":
                    estado1 = "Nuevo Leon";
                    break;
                case "OC":
                    estado1 = "Oaxaca";
                    break;
                case "PL":
                    estado1 = "Puebla";
                    break;
                case "QT":
                    estado1 = "Queretaro";
                    break;
                case "QR":
                    estado1 = "Quintana Roo";
                    break;
                case "SP":
                    estado1 = "San Luis Potosi";
                    break;
                case "SL":
                    estado1 = "Sinaloa";
                    break;
                case "SR":
                    estado1 = "Sonora";
                    break;
                case "TC":
                    estado1 = "Tabasco";
                    break;
                case "TS":
                    estado1 = "Tamaulipas";
                    break;
                case "TL":
                    estado1 = "Tlaxcala";
                    break;
                case "VZ":
                    estado1 = "Veracruz";
                    break;
                case "YN":
                    estado1 = "Yucatan";
                    break;
                case "ZS":
                    estado1 = "Zacatecas";
                    break;
                case "NE":
                    estado1 = "Nacido en el extranjero";
                    break;
            }

            if (sexo == "H")
            {
                sexo1 = "Hombre";
            }
            else
                sexo1 = "Mujer";

            char[] fc = fecha.ToCharArray();

            MessageBox.Show("fecha: " + fc[4] + fc[5] + "/" + fc[2] + fc[3] + "/" + fc[0] + fc[1] + " sexo: " + sexo1 + " estado: " + estado1, "Resultado ",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DTPFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DTPCalculo.Enabled = true;
            DTPCalculo.MinDate = DTPFechaNacimiento.Value;
            BTNCalcular.Enabled = true;
        }

        private void BTNCalcular_Click(object sender, EventArgs e)
        {
            DateTime nacimiento = DTPFechaNacimiento.Value;
            DateTime calculo = DTPCalculo.Value;
            int edad = calculo.Year - nacimiento.Year;
            int meses = calculo.Month - nacimiento.Month;
            int dias = calculo.Day - nacimiento.Day;

            if (dias < 0)
            {
                meses--;
                DateTime mesAnt = calculo.AddMonths(-1);
                dias += DateTime.DaysInMonth(mesAnt.Year, mesAnt.Month);
            }

            if (meses < 0)
            {
                edad--;
                meses += 12;
            }

            MessageBox.Show("Años: " + edad + " Meses: " + meses + " Dias: " + dias, "Resultado ",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
