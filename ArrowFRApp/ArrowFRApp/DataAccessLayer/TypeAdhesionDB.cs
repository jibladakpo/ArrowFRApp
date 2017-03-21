using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowFRApp
{
    class TypeAdhesionDB
    {
        /// <summary>
        /// La méthode GetTypeAdhesion retourne les informations sur un type d'adhésion. 
        /// </summary>
        /// <param name="id">l'id du type d'adhésion</param>
        /// <returns>un type d'adhésion</returns>
        public TypeAdhesion GetTypeAdhesion(int id)
        {
            string connectionString = Initialisation.InitialiserConnexion();
            TypeAdhesion leTypeAdhesion = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idTypeAdhesion, libelle, tarif from typeadhesion WHERE idTypeAdhesion = @id; ";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id", id);

                //Crée un data reader et exécute la commande
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Lit les données 
                    while (dataReader.Read())
                    {

                        int idType = Convert.ToInt32(dataReader["idTypeAdhesion"]);
                        string nom = dataReader["Libelle"].ToString();
                        int tarif = Convert.ToInt32(dataReader["Tarif"]);
                        leTypeAdhesion = new TypeAdhesion(idType, nom, tarif);


                    }
                }
            }


            return leTypeAdhesion;
        }

        
        
        
        //public static List<TypeAdhesion> GetAlltypeAdhesion()
        /// <summary>
        /// La méthode GetAllAdherent retourne les informations sur tous les adhérents de la base.  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>la liste de tous les adhérents</returns>
        public List<TypeAdhesion> GetAllTypeAdhesion()
        {
            string connectionString = Initialisation.InitialiserConnexion();
            List<TypeAdhesion> listeDeTousLesTypesAdhesions = new List<TypeAdhesion>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idTypeAdhesion from typeAdhesion";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);



                //Crée un data reader et exécute la commande
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Lit les données 
                    while (dataReader.Read())
                    {
                        TypeAdhesion leTypeAdhesion = null;
                        int idType = Convert.ToInt32(dataReader["idTypeAdhesion"]);
                        leTypeAdhesion = GetTypeAdhesion(idType);
                        if (leTypeAdhesion != null)
                        {
                            listeDeTousLesTypesAdhesions.Add(leTypeAdhesion);
                        }


                    }
                }
            }


            return listeDeTousLesTypesAdhesions;
        }
        //public void Save()
        /// <summary>
        /// La méthode SaveAdhesion crée un nouveau type d'adhésion s'il n'existe pas et le modifie 
        /// s'il existe déjà dans la base. 
        /// </summary>
        public void Save(TypeAdhesion unTypeAdhesion)
        {
            string connectionString = Initialisation.InitialiserConnexion();
            string query;
            if (unTypeAdhesion.idTypeAdhesion == -1)
            {
                //Création d'un nouvel adhérent    
                query = "insert into typeAdhesion (libelle, tarif) values (@libelle, @tarif);";
            }
            else
            {
                //Modification d'un adhérent
                query = "update typeAdhesion set  idTypeAdhesion = @id, libelle = @libelle, tarif = @tarif";

            }


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id", unTypeAdhesion.idTypeAdhesion);
                cmd.Parameters.AddWithValue("@libelle", unTypeAdhesion.Libelle);
                cmd.Parameters.AddWithValue("@libelle", unTypeAdhesion.Tarif);
                

                //exécution la commande
                cmd.ExecuteNonQuery();

            }
        }
        //public void Delete(int id)
        /// <summary>
        /// TODO.  Supprimer type adhesion
        /// </summary>
        /// <param name="id"></param>
        public static void Delete(int id)
        {

        }
    }
}
