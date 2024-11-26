using Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_GRUPO_02_PR3.FormsAdmin
{
    public partial class Form_Admin_Reportes : System.Web.UI.Page
    {
        LogicaReportes logrep = new LogicaReportes();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LblUsuario.Text = Session["NombreUsuario"] as string;
            }
        }
        public string CorroborarFechas(string txtFechaInicio, string txtFechaFinal, out DateTime fechaInicio, out DateTime fechaFinal)
        {
            string mensajeError = "";
            fechaInicio = DateTime.MinValue;
            fechaFinal = DateTime.MinValue;

            if (!DateTime.TryParseExact(txtFechaInicio, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out fechaInicio))
            {
                mensajeError += "Debe ingresar una fecha de inicio.\n";
            }

            if (!DateTime.TryParseExact(txtFechaFinal, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out fechaFinal))
            {
                mensajeError += "Debe ingresar una fecha final.\n";
            }

            if (string.IsNullOrEmpty(mensajeError) && fechaFinal <= fechaInicio)
            {
                mensajeError += "La fecha final debe ser mayor a la fecha de inicio.\n";
            }

            return mensajeError;
        }
        protected void BtnGenerarReporteN1_Click(object sender, EventArgs e)
        {
            string txtFechaInicio = ((TextBox)FindControl("TxtFechaInicio")).Text;
            string txtFechaFinal = ((TextBox)FindControl("TxtFechaFinal")).Text;

            DateTime fechaInicio;
            DateTime fechaFinal;

            string mensajeError = CorroborarFechas(txtFechaInicio, txtFechaFinal, out fechaInicio, out fechaFinal);

            if (!string.IsNullOrEmpty(mensajeError))
            {
                string scriptvalidacion = $"alert('{mensajeError.Replace("\n", "\\n")}');";
                ClientScript.RegisterStartupScript(this.GetType(), "MensajeError", scriptvalidacion, true);
                return;
            }

            int totalturnos = logrep.ObtenerTotalTurnos(fechaInicio, fechaFinal);
            LblCantTurnos.Text = "Cantidad de Turnos Totales: " + totalturnos.ToString();
            LblCantTurnos.Visible = true;

            if (totalturnos > 0)
            {
                int totalturnospresentes = logrep.ObtenerTotalTurnosPresentes(fechaInicio, fechaFinal);
                double porcentajePresentes = ((double)totalturnospresentes / totalturnos) * 100;
                LblCantPresentes.Text = "Porcentaje de Pacientes Presentes: " + porcentajePresentes.ToString("F2") + "%";
                LblCantPresentes.Visible = true;

                int totalturnosausentes = logrep.ObtenerTotalTurnosAusentes(fechaInicio, fechaFinal);
                double porcentajeausentes = ((double)totalturnosausentes / totalturnos) * 100;
                LblCantAusentes.Text = "Porcentaje de Pacientes Ausentes: " + porcentajeausentes.ToString("F2") + "%";
                LblCantAusentes.Visible = true;
            }

            DataTable dtAusentes = logrep.ObtenerNombrePacientesAusentes(fechaInicio, fechaFinal);
            if (dtAusentes.Rows.Count > 0)
            {
                DdlAusentes.DataSource = dtAusentes;
                DdlAusentes.DataTextField = "Nombre";
                DdlAusentes.DataValueField = "Nombre";
                DdlAusentes.DataBind();
                DdlAusentes.Items.Insert(0, new ListItem("--Lista de Ausentes--", ""));

                LblListAusentes.Visible = true;
                DdlAusentes.Visible = true;
            }

            DataTable dtPresentes = logrep.ObtenerNombrePacientesPresentes(fechaInicio, fechaFinal);
            if (dtPresentes.Rows.Count > 0)
            {
                DdlPrensentes.DataSource = dtPresentes;
                DdlPrensentes.DataTextField = "Nombre";
                DdlPrensentes.DataValueField = "Nombre";
                DdlPrensentes.DataBind();
                DdlPrensentes.Items.Insert(0, new ListItem("--Lista de Presentes--", ""));

                LblListPresentes.Visible = true;
                DdlPrensentes.Visible = true;
            }
        }
        protected void BtnGenerarReporteN2_Click(object sender, EventArgs e)
        {
            string txtFechaInicio = ((TextBox)FindControl("TxtFechaInicio2")).Text;
            string txtFechaFinal = ((TextBox)FindControl("TxtFechaFinal2")).Text;

            DateTime fechaInicio;
            DateTime fechaFinal;

            string mensajeError = CorroborarFechas(txtFechaInicio, txtFechaFinal, out fechaInicio, out fechaFinal);

            if (!string.IsNullOrEmpty(mensajeError))
            {
                string scriptvalidacion = $"alert('{mensajeError.Replace("\n", "\\n")}');";
                ClientScript.RegisterStartupScript(this.GetType(), "MensajeError", scriptvalidacion, true);
                return;
            }

            int totalturnos = logrep.ObtenerTotalTurnos(fechaInicio, fechaFinal);
            LblCantTurnos2.Text = "Cantidad de Turnos Totales: " + totalturnos.ToString();
            LblCantTurnos2.Visible = true;

            if (totalturnos > 0)
            {
                DataTable turnosPorHora = logrep.ObtenerTurnosPorHoras(fechaInicio, fechaFinal, totalturnos);

                DdlTurnosxHoras.Items.Clear();
                DdlTurnosxHoras.Items.Add(new ListItem("Turnos por Hora", ""));

                foreach (DataRow row in turnosPorHora.Rows)
                {
                    string hora = row["Hora"].ToString();
                    string cantidadTurnos = row["CantidadTurnos"].ToString();
                    double porcentaje = Convert.ToDouble(row["Porcentaje"]);
                    string porcentajeFormatted = porcentaje.ToString("F2");
                    DdlTurnosxHoras.Items.Add(new ListItem($"{hora} - {cantidadTurnos} Turnos ({porcentajeFormatted}%)", hora));
                }
                LblTurnosxHoras.Visible = true;
                DdlTurnosxHoras.Visible = true;
            }
        }
    }
}