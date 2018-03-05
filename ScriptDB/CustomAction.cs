using System;
using Microsoft.Deployment.WindowsInstaller;
using Npgsql;
using System.IO;
using System.Reflection;

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

                NpgsqlCommand _cmd = new NpgsqlCommand(_script, _conexion);
                
                _conexion.Open();
                _cmd.ExecuteNonQuery();
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
