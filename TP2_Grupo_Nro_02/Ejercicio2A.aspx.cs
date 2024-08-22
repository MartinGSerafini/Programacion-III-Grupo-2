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

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void Btnverresumen_Click(object sender, EventArgs e)
        {
            
            string selectedItems = "";
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    selectedItems += item.Text + "<br />"; // Puedes cambiar el delimitador si lo prefieres
                }
            }
            Session["SelectedItems"] = selectedItems;
            Server.Transfer("Ejercicio2B.aspx");
        }
    }
}