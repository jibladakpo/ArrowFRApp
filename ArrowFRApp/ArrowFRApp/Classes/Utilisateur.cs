using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowFRApp.Classes
{
    public class Utilisateur
    {
        public int idUtilisateur { get; set; }
        public string login { get; set; }
        public string mdp { get; set; }

        //Constructeur sans id
        public Utilisateur(string leLogin, string leMdp)
        {
            idUtilisateur = -1;
            login = leLogin;
            mdp = leMdp;
        }
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="lutilisateur">L'utilisateur</param>
        /// <param name="leLogin">le Login</param>
        /// <param name="leMdp">le Mdp</param>
        public Utilisateur(int lutilisateur, string leLogin, string leMdp)
        {
            idUtilisateur = -1;
            idUtilisateur = lutilisateur;
            login = leLogin;
            mdp = leMdp;
        }
    }
}
