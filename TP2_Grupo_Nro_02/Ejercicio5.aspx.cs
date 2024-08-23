using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_Nro_XX
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected decimal CalcularMemoria()
        {
            decimal dosgb = 200;
            decimal cuatrogb = 375;
            decimal seisgb = 500;
            decimal memoria = 0;

            switch (Ddlist.SelectedValue)
            {
                case "0":
                    memoria = dosgb;
                    break;
                case "1":
                    memoria = cuatrogb;
                    break;
                case "2":
                    memoria = seisgb;
                    break;
            }
            return memoria;
        }
        protected decimal CalcularAccesorios()
        {
            decimal MonitorLCD = 2000.5m;
            decimal HD500GB = 550.5m;
            decimal GrabadorDVD = 1200;
            decimal accesorios = 0;

            foreach (ListItem item in Cblist.Items)
            {
                if (item.Selected)
                {
                    switch (item.Value)
                    {
                        case "0":
                            accesorios += MonitorLCD;
                            break;
                        case "1":
                            accesorios += HD500GB;
                            break;
                        case "2":
                            accesorios += GrabadorDVD;
                            break;
                    }
                }
            }
            return accesorios;
        }

        protected void Btncalcular_Click(object sender, EventArgs e)
        {
            decimal preciofinal = 0;
            preciofinal = CalcularMemoria() + CalcularAccesorios();
            lblPrecioFinal.Text = "El Precio Final es de " + preciofinal + "$";
        }
    }
}