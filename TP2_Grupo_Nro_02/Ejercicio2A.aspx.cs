using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_Nro_XX
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnverresumen_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Txbnombre.Text) || string.IsNullOrWhiteSpace(Txbapellido.Text) || CheckBoxList.SelectedIndex == -1)
            {
                string Msgerror = "alert('Debe completar todos los campos');";
                ClientScript.RegisterStartupScript(this.GetType(), "Ingreso Incorrecto", Msgerror, true);
            }
            else
            {
                string selectedItems = "";
                foreach (ListItem item in CheckBoxList.Items)
                {
                    if (item.Selected)
                        selectedItems += item.Text + "<br />";
                }
                base.Session["SelectedItems"] = selectedItems;
                Server.Transfer("Ejercicio2B.aspx");
            }
        }
    }
}