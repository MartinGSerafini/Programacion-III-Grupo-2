using Logica;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net;

namespace TPINT_GRUPO_02_PR3.FormsAdmin
{
    public partial class Form_Admin_Agregar_Turno : System.Web.UI.Page
    {
        LogicaPacientes logpac = new LogicaPacientes();
        LogicaMedicos logmed = new LogicaMedicos();
        LogicaHorarioAtencion loghor = new LogicaHorarioAtencion();
        LogicaTurnos logtur = new LogicaTurnos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LblUsuario.Text = Session["NombreUsuario"] as string;
                CargarEspecialidades();
                ddlMedicos.Enabled = false;
                txtDia.Enabled = false;
                DdlHorario.Enabled = false;
            }
        }
        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("Form_Menu_Administrador.aspx");
        }
        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!lblErrorDia.Visible)
            {
                int Idpaciente = logpac.ObtenerPacientePorDNI(txtDNI.Text);
                int especialidad = Convert.ToInt32(ddlespecialidad.SelectedValue);
                string dniMedico = ddlMedicos.SelectedValue;
                DateTime fecha = Convert.ToDateTime(txtDia.Text);
                string horaSeleccionada = DdlHorario.SelectedItem.Text.Trim();
                TimeSpan hora = TimeSpan.Parse(horaSeleccionada);

                if(!logpac.VerificarExistenciaDePaciente(txtDNI.Text)){
                    string script = "alert('El DNI ingresado no Coincide con Ningun Paciente de la Base de Datos');";
                    ClientScript.RegisterStartupScript(this.GetType(), "mensajeError", script, true);
                    return;
                }
                Turnos turno = new Turnos();
                try
                {
                    turno.SetID_PACIENTE_TUR(Idpaciente);
                    turno.SetID_ESPECIALIDAD_TUR(especialidad);
                    turno.SetFK_DNI_MEDICO_TUR(dniMedico);
                    turno.SetFECHA_TUR(fecha);
                    turno.SetHORA_TUR(hora);
                    turno.SetOBSERVACION_TUR("");
                    turno.SetESTADO_TUR("");

                    if (logtur.AgregarTurno(turno))
                    {
                        string script = "alert('El Turno fue agregado con exito');";
                        ClientScript.RegisterStartupScript(this.GetType(), "mensajeError", script, true);
                        limpiarCampos();
                    }
                    else
                    {
                        string script = "alert('El Turno no pudo ser agregado al sistema');";
                        ClientScript.RegisterStartupScript(this.GetType(), "mensajeError", script, true);
                        return;
                    }
                }
                catch (Exception)
                {
                }
            }
            else
            {
                return;
            }
        }
        private void CargarEspecialidades()
        {
            LogicaEspecialidades logesp = new LogicaEspecialidades();
            DataTable dtEspecialidades = logesp.ObtenerTabla();
            if (dtEspecialidades != null && dtEspecialidades.Rows.Count > 0)
            {
                ddlespecialidad.DataSource = dtEspecialidades;
                ddlespecialidad.DataTextField = "Nombre";
                ddlespecialidad.DataValueField = "IDEspecialidad";
                ddlespecialidad.DataBind();
            }

            ddlespecialidad.Items.Insert(0, new ListItem("Seleccione una Especialidad", "-1"));
        }
        protected void ddlespecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlespecialidad.SelectedValue != "-1")
            {
                ddlMedicos.Enabled = true;
            }
            else
            {
                ddlMedicos.Enabled = false;
                txtDia.Enabled = false;
            }
            int idEspecialidad = Convert.ToInt32(ddlespecialidad.SelectedValue);

            if (idEspecialidad > 0)
            {
                CargarMedicos(idEspecialidad);
            }
            else
            {
                ddlMedicos.Items.Clear();
                ddlMedicos.Items.Insert(0, new ListItem("Seleccione un Medico", "-1"));
            }
        }
        private void CargarMedicos(int idEspecialidad)
        {
            DataTable dtMedicos = logmed.getTablaMedicosPorEspecialidad(idEspecialidad);
            if (dtMedicos != null && dtMedicos.Rows.Count > 0)
            {
                ddlMedicos.DataSource = dtMedicos;
                ddlMedicos.DataTextField = "NOMBRE_COMPLETO";
                ddlMedicos.DataValueField = "FK_DNI_MED";
                ddlMedicos.DataBind();
            }
            else
            {
                ddlMedicos.Items.Clear();
                ddlMedicos.Items.Insert(0, new ListItem("No hay médicos disponibles", "-1"));
            }
            ddlMedicos.Items.Insert(0, new ListItem("Seleccionar Médico", "-1"));
        }
        protected void ddlMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlMedicos.SelectedValue != "-1")
            {
                txtDia.Enabled = true;
            }
            else
            {
                txtDia.Enabled = false;
            }

            string dniMedico = ddlMedicos.SelectedValue;
            string diasLaborales = loghor.ObtenerDiasLaborales(dniMedico);

            if (!string.IsNullOrEmpty(diasLaborales))
            {
                var diasNumericos = ConvertirDiasAInt(diasLaborales);
                Session["DiasLaborales"] = diasNumericos;

                DateTime horaInicio = loghor.ObtenerHoraInicio(dniMedico);
                DateTime horaFin = loghor.ObtenerHoraFin(dniMedico);
                string horaSeleccionada = DdlHorario.SelectedValue;
                DdlHorario.Items.Clear();
                DdlHorario.Items.Add(new ListItem("--Seleccione un Horario--", "-1"));

                while (horaInicio < horaFin)
                {
                    string horaFormateada = horaInicio.ToString("HH:mm:ss");
                    DdlHorario.Items.Add(new ListItem(horaFormateada, horaFormateada));
                    horaInicio = horaInicio.AddHours(1);
                }
                if (!string.IsNullOrEmpty(horaSeleccionada) && DdlHorario.Items.FindByValue(horaSeleccionada) != null)
                {
                    DdlHorario.SelectedValue = horaSeleccionada;
                }
            }
        }
        protected void txtDia_TextChanged(object sender, EventArgs e)
        {
            string dniMedico = ddlMedicos.SelectedValue;
            string diasLaborales = loghor.ObtenerDiasLaborales(dniMedico);

            var diasNumericos = ConvertirDiasAInt(diasLaborales);

            DateTime fechaSeleccionada;
            bool fechaValida = DateTime.TryParse(txtDia.Text, out fechaSeleccionada);

            if (fechaValida)
            {
                if (fechaSeleccionada < DateTime.Today)
                {
                    lblErrorDia.Text = "No se pueden seleccionar días anteriores a la fecha actual";
                    lblErrorDia.Visible = true;
                    txtDia.Text = string.Empty;
                    DdlHorario.Enabled = false;
                    return;
                }
                int diaSeleccionado = (int)fechaSeleccionada.DayOfWeek;

                if (!diasNumericos.Contains(diaSeleccionado))
                {
                    string diasLaboralesDisponibles = string.Join(", ", diasLaborales.Split(','));
                    lblErrorDia.Text = $"El médico solo trabaja los días: {diasLaboralesDisponibles}.";
                    lblErrorDia.Visible = true;
                    txtDia.Text = string.Empty; 
                    DdlHorario.Enabled = false;
                }
                else
                {
                    lblErrorDia.Visible = false;
                    DdlHorario.Enabled = true;
                    QuitarHorarios(dniMedico, fechaSeleccionada);
                }
            }
            else
            {
               lblErrorDia.Text = "Ingrese un día válido.";
               lblErrorDia.Visible = true;
               DdlHorario.Enabled = false;
            }
        }
        private void QuitarHorarios(string dniMedico, DateTime fechaSeleccionada)
        {
            if (DateTime.TryParse(txtDia.Text, out fechaSeleccionada))
            {
                var turnosOcupados = logtur.HorariosOcupados(dniMedico, fechaSeleccionada);

                foreach (ListItem item in DdlHorario.Items)
                {
                    if (TimeSpan.TryParse(item.Value, out TimeSpan horarioActual))
                    {
                        if (turnosOcupados.Contains(horarioActual))
                        {
                            item.Attributes.Add("disabled", "true");
                        }
                    }
                }
            }
        }
        private List<int> ConvertirDiasAInt(string diasLaborales)
        {
            Dictionary<string, int> mapaDias = new Dictionary<string, int>
            {
                { "domingo", 0 },
                { "lunes", 1 },
                { "martes", 2 },
                { "miércoles", 3 },
                { "jueves", 4 },
                { "viernes", 5 },
                { "sábado", 6 }
            };
            return diasLaborales
                .Split(',')
                .Select(dia => mapaDias[dia.ToLower().Trim()])
                .ToList();
        }
        private void limpiarCampos()
        {
            txtDNI.Text = "";
            ddlespecialidad.SelectedValue = "-1";
            ddlMedicos.SelectedValue = "-1";
            txtDia.Text = "";
            DdlHorario.SelectedValue = "-1";
        }
    }
}