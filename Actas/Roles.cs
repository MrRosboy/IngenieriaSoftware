﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actas
{
    public partial class Roles : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe;PASSWORD=admin;USER ID=admin;");
        public Roles()
        {
            InitializeComponent();
        }

        private void btnMostrarRoles_Click(object sender, EventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("prueba", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvRoles.DataSource = dt;

            cbxDescRoles.Text = "";
            cbxEstRoles.Text = "";
            conexion.Close();
        }

        private void btnCrearRoles_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comandoCrear = new OracleCommand("insertar_roles", conexion);   
                comandoCrear.CommandType = System.Data.CommandType.StoredProcedure;
                comandoCrear.Parameters.Add("descripcion", OracleType.VarChar).Value = cbxDescRoles.Text;
                comandoCrear.Parameters.Add("estatus", OracleType.VarChar).Value = cbxEstRoles.Text;
                comandoCrear.ExecuteNonQuery();
                MessageBox.Show("Rol Creado");
            }
            catch (Exception) 
            {
                MessageBox.Show("Algo fallo");
            }
      
            conexion.Close() ;
        }

        private void Roles_Load(object sender, EventArgs e)

        {
            conexion.Open();
            OracleCommand cargarcbxdesc = new OracleCommand("select descripcion from roles",conexion);
            OracleDataReader carga = cargarcbxdesc.ExecuteReader();
            while (carga.Read()) 
            {
                cbxDescRoles.Items.Add(carga["descripcion"].ToString());
            }
            conexion.Close();
        }

        private void btnActuRoles_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open() ;
                OracleCommand comandoAct = new OracleCommand("actualizar_roles", conexion);
                comandoAct.CommandType = System.Data.CommandType.StoredProcedure;
                comandoAct.Parameters.Add("descripcion", OracleType.VarChar).Value = cbxDescRoles.Text;
                comandoAct.Parameters.Add("estatus", OracleType.VarChar).Value = cbxEstRoles.Text;
                comandoAct.ExecuteNonQuery();
                MessageBox.Show("Rol Actualizado");
                
            } catch(Exception) 
            {
                MessageBox.Show("Algo Fallo");
            }
           conexion.Close();
        }

        private void btnEliminarRoles_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();    
                OracleCommand comandoElim = new OracleCommand("eliminar_roles", conexion);
                comandoElim.CommandType = System.Data.CommandType.StoredProcedure;
                comandoElim.Parameters.Add("descripcion", OracleType.VarChar).Value= cbxDescRoles.Text;
                comandoElim.ExecuteNonQuery ();
                MessageBox.Show("Rol Eliminado");

            }catch(Exception) 
            {
                MessageBox.Show("Algo Fallo");

            }
           conexion.Close ();

        }

        private void cbxDescRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
