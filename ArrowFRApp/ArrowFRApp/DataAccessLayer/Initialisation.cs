using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowFRApp
{
    class Initialisation
    {
        /// <summary>
        /// Retourne la chaine de connexion. On prendra soin de ne pas utiliser l'utilisateur root avec un password vide comme ici!
        /// </summary>
        public static string InitialiserConnexion()
        {

            string server = "localhost";
            string port = "3306";
            string database = "arrowfr";
            string uid = "root";
            string password = "";
            return "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        }
    }
}
