using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Deployment.WindowsInstaller;
using Npgsql;
using System.IO;
using System.Reflection;
using System.Data;
using System.Windows.Forms;

namespace ScriptDB
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult CustomAction1(Session session)
        {
            try
            {
                string _connStr = "Server=localhost;Port=5432;User Id=flymail;Database=flymail";
                NpgsqlConnection _conexion = new NpgsqlConnection(_connStr);

                Assembly _assembly = Assembly.GetExecutingAssembly();
                StreamReader _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("ScriptDB.scriptDB.txt"));
                string _script = _textStreamReader.ReadToEnd();
                MessageBox.Show("Se obtuvo acceso al archivo..");

                NpgsqlCommand _cmd = new NpgsqlCommand(_script, _conexion);
                
                _conexion.Open();
                MessageBox.Show("Conexión abierta!");
                _cmd.ExecuteNonQuery();
                MessageBox.Show("Se ejecutó el query!!");
                _conexion.Close();
            }
            catch (Exception)
            {
                return ActionResult.UserExit;
            }

            return ActionResult.Success;
        }
    }
}
