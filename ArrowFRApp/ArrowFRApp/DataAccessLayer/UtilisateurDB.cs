using ArrowFRApp.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowFRApp.DataAccessLayer
{
    public class UtilisateurDB
    {
        public string mdp { get; set; }
        public string login { get; set; }

        public  Utilisateur GetUtilisateur(int id)
        {
            string connectionString = Initialisation.InitialiserConnexion();
            Utilisateur lUtilisateur = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idUtilisateur, login, mdp; ";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id", id);

                //Crée un data reader et exécute la commande
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Lit les données 
                    while (dataReader.Read())
                    {

                        int idUtilisateur = Convert.ToInt32(dataReader["idUtilisateur"]);
                        string login = dataReader["login"].ToString();
                        string mdp = dataReader["mdp"].ToString();
                        


                    }
                }
            }


            return lUtilisateur;
        }

        public List<Utilisateur> GetAllUtilisateur()
        {
            string connectionString = Initialisation.InitialiserConnexion();
            List<Utilisateur> listeDeTousLesUtilisateurs = new List<Utilisateur>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idUtilisateur from utilisateur";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);



                //Crée un data reader et exécute la commande
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Lit les données 
                    while (dataReader.Read())
                    {
                        Utilisateur lUtilisateur = null;
                        int idUtilisateur = Convert.ToInt32(dataReader["idUtilisateur"]);
                        lUtilisateur = GetUtilisateur(idUtilisateur);
                        if (lUtilisateur != null)
                        {
                            listeDeTousLesUtilisateurs.Add(lUtilisateur);
                        }


                    }
                }
            }


            return listeDeTousLesUtilisateurs;
        }

        public bool CheckAuth()
        {
            string connectionString = Initialisation.InitialiserConnexion();
            MySqlConnection sqlcon = new MySqlConnection(connectionString);

            string query = "Select * From Utilisateur Where login = '"+ login +"' and mdp = '"+ mdp +"'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, sqlcon);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            bool Auth = false;
            

                if (dt1.Rows.Count == 1)
                {
                    Auth = true;
                }
                else
                {
                    Auth = false;

                }

                return Auth ;
            }
        }
    }

