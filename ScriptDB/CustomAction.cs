using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Deployment.WindowsInstaller;

namespace ScriptDB
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult CustomAction1(Session session)
        {
            session.Log("Begin CustomAction1");

            //Scipt para configurar la base de datos!
            // Este comentario lo hice antes de romper todo. Espero que salga todo bien!

            return ActionResult.Success;
        }
    }
}
