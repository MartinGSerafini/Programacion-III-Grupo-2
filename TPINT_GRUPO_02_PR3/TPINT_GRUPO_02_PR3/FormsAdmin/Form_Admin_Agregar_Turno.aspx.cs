using Logica;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_GRUPO_02_PR3.FormsAdmin
{
    public partial class Form_Admin_Agregar_Turno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LblUsuario.Text = Session["NombreUsuario"] as string;
                CargarEspecialidades();
            }
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            LogicaPacientes logicaPac = new LogicaPacientes();
            LogicaTurnos logicaTur = new LogicaTurnos();

            string dni = txtDNI.Text.Trim();

            if (logicaPac.VerificarExistenciaDePaciente(dni))
            {
                Turnos Tur = new Turnos();
                Tur.setIdMedico(logicaTur.BuscarIdMedico(ddlMedico.SelectedValue));
                Tur.setIdPaciente(logicaTur.BuscarIdPaciente(dni));
                Tur.setEspecialidad(Convert.ToInt32(ddlEspecialidad.SelectedValue));
                //Tur.setFecha();
                Tur.setHora(ddlHora.Text);
                Tur.setEstado("Activo");
                bool validTurno = logicaTur.AgregarTurno(Tur);
                if (validTurno)
                {
                    string script = "alert('El Medico fue Ingresado al Sistema.');";
                    ClientScript.RegisterStartupScript(this.GetType(), "mensajeExito", script, true);
                    limpiarCampos();
                }
                else
                {
                    string script = "alert('Hubo un problema al Ingresar al Medico al sistema.');";
                    ClientScript.RegisterStartupScript(this.GetType(), "mensajeError", script, true);
                }
            }
            else
            {
                string script = "alert('El DNI no está registrado.');";
                ClientScript.RegisterStartupScript(this.GetType(), "mensajeError", script, true);
                return;
            }
        }

        private void CargarEspecialidades()//CARGA LAS ESPECIALIDADES
        {
            LogicaMedicos logica = new LogicaMedicos();
            DataTable dtEspecialidades = logica.getTabla();
            ddlEspecialidad.DataSource = dtEspecialidades;
            ddlEspecialidad.DataTextField = "Nombre";
            ddlEspecialidad.DataValueField = "IDEspecialidad";
            ddlEspecialidad.DataBind();

            ddlEspecialidad.Items.Insert(0, new ListItem("--Seleccione la especialidad--", "0"));
        }

        protected void ddlEspecialidad_SelectedIndexChanged(object sender, EventArgs e)//TOMA EL ID ESPECIALIDAD Y CARGA LOS MEDICOS
        {
            int idEspecialidad = Convert.ToInt32(ddlEspecialidad.SelectedValue);

            if (idEspecialidad > 0)
            {
                ddlDia.Items.Clear();
                ddlDia.Items.Insert(0, new ListItem("--Seleccione un día--", "-1"));
                CargarMedicos(idEspecialidad);
            }
            else
            {
                ddlMedico.Items.Clear();
                ddlMedico.Items.Insert(0, new ListItem("--Seleccione un medico--", "-1"));
            }
        }

        private void CargarMedicos(int idEspecialidad)
        {
            LogicaMedicos logica = new LogicaMedicos();
            DataTable dtMedicos = logica.GetTablaMedicosXidEsp(idEspecialidad);
            ddlMedico.DataSource = dtMedicos;
            ddlMedico.DataTextField = "NombreCompleto";
            ddlMedico.DataValueField = "DNI";
            ddlMedico.DataBind();

            ddlMedico.Items.Insert(0, new ListItem("--Seleccione un medico--", "-1"));
        }

        protected void ddlMedico_SelectedIndexChanged(object sender, EventArgs e)//TOMA EL DNI MEDICO Y CARGA LOS DIAS Y HORARIOS
        {
            string DNIMedico = ddlMedico.SelectedValue;

            if (DNIMedico != "-1")
            {
                ddlDia.Items.Clear();
                CargarHorarios(DNIMedico);
                CargarDias(DNIMedico);
            }
            else
            {
                ddlDia.Items.Clear();
                ddlDia.Items.Insert(0, new ListItem("--Seleccione un día--", "-1"));
            }
        }

        private void CargarDias(string DNI)//LLAMA A LOGICAMEDICOS Y OBTIENE ARRAY CON LOS DIAS SEGUN EL DNI
        {
            LogicaMedicos logica = new LogicaMedicos();
            string Dias = logica.GetDiasMedico(DNI);//obtiene un string
            string[] arrayDias = Dias.Split(',');//convierte el string en array

            ddlDia.Items.Insert(0, new ListItem("--Seleccione un día--", "-1"));
            for (int i = 0; i < arrayDias.Length; i++)//guarda los elementos del array en el ddl
            {
                ddlDia.Items.Insert(i + 1, new ListItem(arrayDias[i]));
            }
        }

        private void CargarHorarios(string DNI)//LLAMA LOGICAMEDICOS Y OBTIENE LA HORA DE INICIO Y LA HORA DE FINALIZACION
        {
            LogicaMedicos logica = new LogicaMedicos();//obtiene un string de hora inicio y un string de hora fin
            string HoraInicio = logica.GetHorarioMedico(DNI, "HoraInicio");
            string HoraFin = logica.GetHorarioMedico(DNI, "HoraFin");
            int horaIni = Convert.ToInt32(HoraInicio.Substring(0,2));//toma los 2 primeros caracteres de las horas y los convierte en INT
            int horafin = Convert.ToInt32(HoraFin.Substring(0, 2));
            List<string> listHoras = new List<string>();//crea una lista
            for (int i = horaIni; i <= horafin; i++)
            {//llena la lista con las horas disponibles del medico
                if(i < 10)
                {
                    listHoras.Add("0" + i + ":00");
                    listHoras.Add("0" + i + ":15");
                    listHoras.Add("0" + i + ":30");
                    listHoras.Add("0" + i + ":45");
                }
                else
                {
                    listHoras.Add(i + ":00");
                    listHoras.Add(i + ":15");
                    listHoras.Add(i + ":30");
                    listHoras.Add(i + ":45");
                }
            }
            for(int i = 0; i < listHoras.Count; i++)//guarda los elementos en el ddl
            {
                ddlHora.Items.Insert(i + 1, new ListItem(listHoras[i]));
            }
        }

        private void limpiarCampos()
        {
            txtDNI.Text = "";
            ddlEspecialidad.SelectedIndex = 0;
            ddlMedico.SelectedIndex = 0;
            ddlDia.SelectedIndex = 0;
            ddlHora.SelectedIndex = 0;
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("Form_Menu_Administrador.aspx");
        }
    }
}