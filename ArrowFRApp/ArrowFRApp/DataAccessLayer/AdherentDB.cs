using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowFRApp
{
    class AdherentDB
    {
        /// <summary>
        /// La méthode GetAdherent retourne les informations sur un adherent. 
        /// </summary>
        /// <param name="id">l'id de l'adhérent</param>
        /// <returns>un adhérent</returns>
        public  Adherent GetAdherent(int id)
        {
            string connectionString = Initialisation.InitialiserConnexion();
            Adherent lAdherent = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idAdherent, nom, prenom, dateNaissance, ville,codePostal,  typeAdhesion from adherent WHERE idAdherent = @id; ";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id", id);

                //Crée un data reader et exécute la commande
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Lit les données 
                    while (dataReader.Read())
                    {

                        int idAdherent = Convert.ToInt32(dataReader["idAdherent"]);
                        string nom = dataReader["nom"].ToString();
                        string prenom = dataReader["prenom"].ToString();
                        DateTime annee = Convert.ToDateTime(dataReader["dateNaissance"]);
                        string ville = dataReader["ville"].ToString();
                        string cp = dataReader["codePostal"].ToString();
                        
                        int idType = Convert.ToInt32(dataReader["typeAdhesion"]);
                        TypeAdhesionDB typeDB = new TypeAdhesionDB();
                        TypeAdhesion leTypeDeAdherent = typeDB.GetTypeAdhesion(idType);
                        lAdherent = new Adherent(idAdherent, nom, prenom, annee, ville, cp, leTypeDeAdherent);


                    }
                }
            }


            return lAdherent;
        }

        /// <summary>
        /// La méthode GetAllAdherent retourne les informations sur tous les adhérents de la base.  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>la liste de tous les adhérents</returns>
        public  List<Adherent> GetAllAdherent()
        {
            string connectionString = Initialisation.InitialiserConnexion();
            List<Adherent> listeDeTousLesAdherents = new List<Adherent>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idAdherent from adherent";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);



                //Crée un data reader et exécute la commande
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Lit les données 
                    while (dataReader.Read())
                    {
                        Adherent lAdherent = null;
                        int idAdherent = Convert.ToInt32(dataReader["idAdherent"]);
                        lAdherent = GetAdherent(idAdherent);
                        if (lAdherent != null)
                        {
                            listeDeTousLesAdherents.Add(lAdherent);
                        }


                    }
                }
            }


            return listeDeTousLesAdherents;
        }

        /// <summary>
        /// La méthode SaveAdherent crée un nouvel adhérent s'il n'existe pas et le modifie 
        /// s'il existe déjà dans la base. 
        /// </summary>
        public void Save(Adherent unAdherent)
        {
            string connectionString = Initialisation.InitialiserConnexion();
            string query;
            if (unAdherent.GetId() == -1)
            {
                //Création d'un nouvel adhérent    
                query = "insert into adherent (nom, prenom,  dateNaissance, ville,codePostal, typeAdhesion) values (@nom, @prenom, @dateNaissance, @ville, @codePostal,  @typeAdhesion);";
            }
            else
            {
                //Modification d'un adhérent
                query = "update adherent set  idAdherent = @id, nom = @nom, prenom = @prenom,  dateNaissance = @dateNaissance,ville = @ville,codePostal = @codePostal,  typeAdhesion = @typeAdhesion where idAdherent = @id";

            }


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id", unAdherent.GetId());
                cmd.Parameters.AddWithValue("@nom", unAdherent.GetNom());
                cmd.Parameters.AddWithValue("@prenom", unAdherent.GetPrenom());
                cmd.Parameters.AddWithValue("@dateNaissance", unAdherent.GetDateDeNaissance().ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@ville", unAdherent.GetVille());
                cmd.Parameters.AddWithValue("@codePostal", unAdherent.GetCodePostal());
                cmd.Parameters.AddWithValue("@typeAdhesion", unAdherent.GetTypeAdherent().idTypeAdhesion);

                //exécution la commande
                cmd.ExecuteNonQuery();
                

            }
        }

        /// <summary>
        /// TODO.  Supprimer adherent
        /// </summary>
        /// <param name="id"></param>
        public static void Delete(int id)
        {
            string connectionString = Initialisation.InitialiserConnexion();
            string query;
                   
            query = "delete from adherent where idTypeAdhesion='"+id+"'";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //exécution la commande
                cmd.ExecuteNonQuery();
            }
        }
    }
}
