﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrowFRApp
{
    public class TypeAdhesionDB
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
                        string libelle = dataReader["Libelle"].ToString();
                        int tarif = Convert.ToInt32(dataReader["Tarif"]);
                        leTypeAdhesion = new TypeAdhesion(idType, libelle, tarif);


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
                //Création d'un nouveeau type d'adhésion   
                query = "insert into typeAdhesion (libelle, tarif) values (@libelle, @tarif);";
            }
            else
            {
                //Modification d'un type d'adhésion
                query = "update typeAdhesion set  idTypeAdhesion = @idtype, libelle = @libelle, tarif = @tarif where idTypeAdhesion = @idtype";

            }


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@idtype", unTypeAdhesion.idTypeAdhesion);
                cmd.Parameters.AddWithValue("@libelle", unTypeAdhesion.Libelle);
                cmd.Parameters.AddWithValue("@tarif", unTypeAdhesion.Tarif);


                //exécution la commande
                cmd.ExecuteNonQuery();

            }
        }
        //public void Delete(int id)
        /// <summary>
        /// TODO.  Supprimer type adhesion
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            string connectionString = Initialisation.InitialiserConnexion();
            string query;

            query = "delete from typeadhesion where idTypeAdhesion = @id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);


                //exécution la commande
                cmd.ExecuteNonQuery();
            }
        }
        //Nombre d'adhésion par type 

        public int NbAdhesionParType(string libelle)
        {
            string connectionString = Initialisation.InitialiserConnexion();
            string query;

            query = "SELECT COUNT(libelle)As NbAdhesionParType From adherent, typeadhesion WHERE adherent.TypeAdhesion = typeadhesion.idTypeAdhesion AND libelle = @libelle GROUP BY libelle  ";
            Int32 count = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@libelle", libelle);

                //Crée un data reader et exécute la commande
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                while (dataReader.Read())
                {

                   // int idType = Convert.ToInt32(dataReader["idTypeAdhesion"]);
                        count = Convert.ToInt32(dataReader["NbAdhesionParType"]);


                }
                return count;
            }

          

        }

        //Montant des adhésion par type
        //à coder!!!

        public int MontantAdhesionParType(string libelle)
        {
            string connectionString = Initialisation.InitialiserConnexion();
            string query;

            query = "SELECT tarif * count(idAdherent) As MtAdhesionParType From adherent, typeadhesion WHERE adherent.TypeAdhesion = typeadhesion.idTypeAdhesion AND libelle = @libelle GROUP BY libelle";
            Int32 result = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@libelle", libelle);

                //Crée un data reader et exécute la commande
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    while (dataReader.Read())
                    {

                        // int idType = Convert.ToInt32(dataReader["idTypeAdhesion"]);
                        result = Convert.ToInt32(dataReader["MtAdhesionParType"]);


                    }


                return result;
            }
        }
    }
}
