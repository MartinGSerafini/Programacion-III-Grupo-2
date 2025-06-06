﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.ModelBinding;

namespace Programacion3_Grupo2_TP4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {

                using (SqlConnection bdViajes = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True"))
                {
                    bdViajes.Open();

                    SqlCommand cmd = new SqlCommand("select idProvincia, Nombreprovincia from PROVINCIAS", bdViajes);

                    SqlDataReader reader = cmd.ExecuteReader();

                    DdlProvinciainicio.DataSource = reader;
                    DdlProvinciainicio.DataTextField = "NombreProvincia";
                    DdlProvinciainicio.DataValueField = "idProvincia";
                    DdlProvinciainicio.DataBind();
                    
                    DdlProvinciainicio.Items.Insert(0, new ListItem("Seleccione una provincia", ""));
                }
            }
        }

        protected void DdlProvinciainicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            DdlLocalidadInicio.Items.Clear();
            DdlProvinciaFinal.Items.Clear();
            DdlLocalidadFinal.Items.Clear();

            using (SqlConnection bdViajes = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True"))
            {
                bdViajes.Open();
                SqlCommand cmd = new SqlCommand("select IdLocalidad, NombreLocalidad from localidades where IdProvincia = @IdProvincia", bdViajes);
                cmd.Parameters.AddWithValue("@IdProvincia", DdlProvinciainicio.SelectedValue);
                SqlDataReader reader = cmd.ExecuteReader();

                DdlLocalidadInicio.DataSource = reader;
                DdlLocalidadInicio.DataTextField = "NombreLocalidad";
                DdlLocalidadInicio.DataValueField = "idlocalidad";
                DdlLocalidadInicio.DataBind();

                DdlLocalidadInicio.Items.Insert(0, new ListItem("Seleccione una localidad", ""));
            }

            using (SqlConnection bdViajes = new SqlConnection("Data Source = localhost\\sqlexpress; Initial Catalog = Viajes; Integrated Security = True"))
            {
                bdViajes.Open();

                string ProvInicio = DdlProvinciainicio.SelectedValue;

                SqlCommand cmd = new SqlCommand("SELECT idProvincia, Nombreprovincia FROM PROVINCIAS WHERE NOT idProvincia = " + ProvInicio, bdViajes);
                cmd.Parameters.AddWithValue("@IdProvincia", DdlProvinciainicio.SelectedValue);
                SqlDataReader reader = cmd.ExecuteReader();

                DdlProvinciaFinal.DataSource = reader;
                DdlProvinciaFinal.DataTextField = "NombreProvincia";
                DdlProvinciaFinal.DataValueField = "idProvincia";
                DdlProvinciaFinal.DataBind();

                DdlProvinciaFinal.Items.Insert(0, new ListItem("Seleccione una provincia", ""));
            }
        }

        protected void DdlProvinicaFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection bdViajes = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True"))
            {
                bdViajes.Open();
                SqlCommand cmd = new SqlCommand("select IdLocalidad, NombreLocalidad from localidades where IdProvincia = @IdProvincia", bdViajes);
                cmd.Parameters.AddWithValue("@IdProvincia", DdlProvinciaFinal.SelectedValue);
                SqlDataReader reader = cmd.ExecuteReader();

                DdlLocalidadFinal.DataSource = reader;
                DdlLocalidadFinal.DataTextField = "NombreLocalidad";
                DdlLocalidadFinal.DataValueField = "IdLocalidad";
                DdlLocalidadFinal.DataBind();
                
                DdlLocalidadFinal.Items.Insert(0, new ListItem("Seleccione una localidad", ""));
            }
        }
    }
}