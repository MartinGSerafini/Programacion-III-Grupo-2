using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Logica;

namespace TPINT_GRUPO_02_PR3.FormsAdmin
{
    public partial class Form_Admin_Reportes : System.Web.UI.Page
    {
        LogicaTurnos logTur = new LogicaTurnos();
        protected void Page_Load(object sender, EventArgs e)
        {
            {//Reporte de presentes y ausentes

                int presentes = logTur.cantidadTurnosEstado("Presente");
                int ausentes = logTur.cantidadTurnosEstado("Ausente");

                int porcentajePresentes = presentes * 100 / (presentes + ausentes);
                int porcentajeAusentes = ausentes * 100 / (presentes + ausentes);

                lblReportePyA1.Text = "Presenetes = " + porcentajePresentes + "%";
                lblReportePyA2.Text = "Ausentes = " + porcentajeAusentes + "%";
            }

            {//Reporte de Especialidades

                lblReporteEsp1.Text = "Especialidad con más turnos: " + logTur.devolverEspecialidadMax();
                lblReporteEsp2.Text = "Espécialidad con menos turnos: " + logTur.devolverEspecialidadMin();

                DataTable dt = logTur.EspecialidadesXturnosReportes();

                grdEspecialidadesXturnos.DataSource = dt;
                grdEspecialidadesXturnos.DataBind();
            }
        }
    }
}