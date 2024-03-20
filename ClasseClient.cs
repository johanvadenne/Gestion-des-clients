using Classe_Rideau;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_clients
{
    public class ClasseClient
    {
        // instancier la classe d'accès aux données
        ClasseADO BdRideau = new ClasseADO();

        // propriétés table client
        public int numClient { get; set; }
        public string nomClient { get; set; }
        public string prenomClient { get; set; }


        public ClasseClient()
        {
        }

        public ClasseClient(int NUMCLIENT, string NOMCLIENT, string PRENOMCLIENT)
        {
            numClient = NUMCLIENT;
            nomClient = NOMCLIENT;
            prenomClient = PRENOMCLIENT;
        }


        public DataTable SQLClients()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT NUMCLIENT, NOMCLIENT, PRENOMCLIENT, TRIM(NOMCLIENT) + ' ' + TRIM(PRENOMCLIENT) as NomPrenom FROM CLIENT", BdRideau.ConnexionBase());

            DataTable DtClients = new DataTable();
            DtClients.Load(sqlCmd.ExecuteReader());
            return DtClients;
        }

        public Int16 SQLMaxNumClient()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT MAX(NUMCLIENT) FROM CLIENT", BdRideau.ConnexionBase());

            return (Int16)sqlCmd.ExecuteScalar();
        }

        // insert into CLIENT values(NUMCLIENT, NOMCLIENT, PRENOMCLIENT)
        public int SQLInsertClient(int NumClient, string NomClient, string PrenomClient)
        {
            this.numClient = NumClient;
            this.nomClient = NomClient;
            this.prenomClient = PrenomClient;

            SqlCommand sqlCmd = new SqlCommand("insert into CLIENT values(" + NumClient + ",'" + NomClient + "','" + PrenomClient + "')", BdRideau.ConnexionBase());

            return (int)sqlCmd.ExecuteNonQuery();
        }

        // Supprimer un CLIENT
        public int SQLDeleteClient(int NumClient)
        {
            SqlCommand sqlCmd = new SqlCommand("DELETE FROM CLIENT WHERE NUMCLIENT = " + NumClient, BdRideau.ConnexionBase());

            return (int)sqlCmd.ExecuteNonQuery();
        }

        // Modifier un CLIENT
        public int SQLUpdateClient(int NumClient, string NomClient, string PrenomClient)
        {
            SqlCommand sqlCmd = new SqlCommand("update CLIENT set NOMCLIENT ='" + NomClient + "', PRENOMCLIENT ='" + PrenomClient + "'" + " where NUMCLIENT = " + NumClient, BdRideau.ConnexionBase());

            // Enregistrement courant mis à jour            
            this.nomClient = NomClient;
            this.prenomClient = PrenomClient;

            return (int)sqlCmd.ExecuteNonQuery();
        }

        // Selectionner un CLIENT
        public DataTable SQLSelectClient(int NumClient)
        {
            string ChSqlCmd = "select * from CLIENT where NUMCLIENT=" + NumClient;
            SqlCommand sqlCmd = new SqlCommand(ChSqlCmd, BdRideau.ConnexionBase());

            // On exécute un curseur pour traiter les données dans la classe
            SqlDataReader reader = sqlCmd.ExecuteReader();
            reader.Read();
            this.numClient = Convert.ToInt32(reader["NUMCLIENT"].ToString());
            this.nomClient = reader["NOMCLIENT"].ToString();
            this.prenomClient = reader["PRENOMCLIENT"].ToString();
            reader.Close();

            // on Affecte le DataReader dans un DataTable pour l'application cliente
            DataTable DtSelectClient = new DataTable();
            DtSelectClient.Load(sqlCmd.ExecuteReader());

            return DtSelectClient;
        }

    }

}
