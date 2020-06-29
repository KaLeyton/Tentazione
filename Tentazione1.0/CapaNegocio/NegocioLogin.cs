﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDTO;
using CapaConexion;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CapaNegocio
{
    public class NegocioLogin
    {

        private Conexion conect;

        public Conexion Conect { get => conect; set => conect = value; }

        public void configurarConexion()
        {
            this.conect = new Conexion();
            this.Conect.NombreBaseDeDatos = "Tentazione";
            this.Conect.NombreTabla = "tbUsuario";
            this.Conect.CadenaConexion = "Data Source=KALEYTON\\SQLEXPRESS;Initial Catalog=Tentazione;Integrated Security=True";
        }

        public bool ValidaLogIn(Usuario usuario)
        {
            DataTable dt = new DataTable();
            try
            {
                this.configurarConexion();
                //this.Conect.CadenaSQL = "SELECT NombreUsuario, Contrasena FROM tbUsuario WHERE NombreUsuario = '"
                //                         + usuario.NombreUsuario + "' AND Contrasena = '" + usuario.Contrasena + "';";
                this.Conect.EsSelect = true;
                this.Conect.conectar();
                ////Opcion1 uwu, creo que esto sirve.
                //this.Conect.DbDataSet(dt);
                //Opcion2 owo, probar con esto equisde.
                dt = this.Conect.DbDataSet.Tables[this.Conect.NombreTabla];
                if (dt.Rows.Count==1)
                {
                    MessageBox.Show("Por fin dice que esta wea funciona WHOHOO");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                _ = e.Message;
                return false;
            }
        }
    }
}
